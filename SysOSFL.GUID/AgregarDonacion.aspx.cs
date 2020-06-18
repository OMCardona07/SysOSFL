using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysOSFL.EN;
using SysOSFL.BL;
using System.Data;
using System.Data.SqlClient;

namespace SysOSFL.GUID
{
    public partial class AgregarDonacion : System.Web.UI.Page
    {
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

        Donaciones _donacion = new Donaciones();
        DonacionesBL _donacionBL = new DonacionesBL();
        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarDonante();
            LlenarProyecto();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                _donacion.IdDonante = Convert.ToInt32(ddlDonante.SelectedValue);
                _donacion.IdProyecto = Convert.ToInt32(ddlDonante.SelectedValue);
                _donacion.Monto = txtMonto.Text;
                _donacion.Estado = ddlEstado.Text;
               

                _donacionBL.AgregarDonacion(_donacion);
                string script = "alert('El administrador se ha registrado exitosamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);

                //txtNombreEm.Text = "";
                //txtNrc.Text = "";
                //txtTelefono.Text = "";
                //txtEmail.Text = "";
                //txtNomUsu.Text = "";
                //txtPass.Text = "";
            }
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