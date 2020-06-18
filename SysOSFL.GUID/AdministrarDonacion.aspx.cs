using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysOSFL.BL;
using SysOSFL.EN;
using System.Data.SqlClient;
using System.Data;

namespace SysOSFL.GUID
{
    public partial class AdministrarDonacion : System.Web.UI.Page
    {
        private void Obtener()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Donaciones.IdDonacion, Donante.NombreEm,Proyecto.Nombre, Donaciones.Monto, Donaciones.Estado FROM Donaciones inner join Proyecto on Donaciones.Id_pro = Proyecto.IdProyecto inner join Donante on Donaciones.IdDonante = Donante.IdDonante WHERE Proyecto.Codigo_pro LIKE'" + txtId.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.gvDonacion.DataSource = dt;
            gvDonacion.DataBind();
        }

        public void LlenarDonante()
        {
            if (!this.IsPostBack)
            {
                {
                    using (SqlCommand cmd = new SqlCommand("select IdDonante, NombreEm from Donante where IdDonante > 0"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = cn;
                        cn.Open();
                        ddlDonante.DataSource = cmd.ExecuteReader();
                        ddlDonante.DataTextField = "NombreEm";
                        ddlDonante.DataValueField = "IdDonante";
                        ddlDonante.DataBind();
                        cn.Close();
                        ddlDonante.Items.Insert(0, "--SELECCIONE DONANTE--");
                    }
                }
            }
        }

        public void LlenarProyecto()
        {
            if (!this.IsPostBack)
            {
                {
                    using (SqlCommand cmd = new SqlCommand("select IdProyecto, Nombre from Proyecto where IdProyecto > 0"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = cn;
                        cn.Open();
                        ddlProyecto.DataSource = cmd.ExecuteReader();
                        ddlProyecto.DataTextField = "Nombre";
                        ddlProyecto.DataValueField = "IdProyecto";
                        ddlProyecto.DataBind();
                        cn.Close();
                        ddlProyecto.Items.Insert(0, "--SELECCIONE UN PROYECTO--");
                    }
                }
            }
        }

        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        Donaciones _donacion = new Donaciones();
        DonacionesBL _donacionesBL = new DonacionesBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarDonante();
            LlenarProyecto();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Obtener();
            }
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            int rowind = ((DataGridItem)(sender as Control).NamingContainer).ItemIndex;

            txtIdDonacion.Text = gvDonacion.Items[rowind].Cells[0].Text;
            txtMonto.Text = gvDonacion.Items[rowind].Cells[3].Text;
            
            

            //txtNombreEm.ReadOnly = false;
            //txtNrc.ReadOnly = false;
            //txtEmail.ReadOnly = false;
            //txtTelefono.ReadOnly = false;
            //txtNomUsu.ReadOnly = false;
            //txtPass.ReadOnly = false;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                _donacion.IdDonacion = Convert.ToInt64(txtIdDonacion.Text);
                _donacion.IdDonante = Convert.ToInt32(ddlDonante.SelectedValue);
                _donacion.IdProyecto = Convert.ToInt32(ddlProyecto.SelectedValue);
                _donacion.Monto = txtMonto.Text;
                _donacion.Estado = ddlEstado.Text;

                if (_donacion.IdDonacion != 0)
                {
                    _donacionesBL.ModificarDonacion(_donacion);
                    string script = "alert('El donante se ha modificado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    //Limpiar();
                    //Solo_Lectura();
                }
            }
            else { }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void ddlProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True"))
            {
                var cmd = new SqlCommand("select Presupuesto from Proyecto where IdProyecto =@IdProyecto", conn);
                cmd.Parameters.AddWithValue("@IdProyecto", ddlProyecto.SelectedValue);
                cmd.Connection = conn;
                conn.Open();
                var itemId = "";
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        itemId = reader[0].ToString();
                    }
                }

                conn.Close();
                txtMonto.Text = itemId;
            }
        }
    }
}