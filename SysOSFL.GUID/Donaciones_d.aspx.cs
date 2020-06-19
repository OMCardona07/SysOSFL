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
    public partial class Donaciones_d : System.Web.UI.Page
    {
        private void Obtener()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Donaciones.IdDonacion, Donante.NombreEm,Proyecto.Nombre, Donaciones.Monto, Donaciones.Estado FROM Donaciones inner join Proyecto on Donaciones.Id_pro = Proyecto.IdProyecto inner join Donante on Donaciones.IdDonante = Donante.IdDonante WHERE Proyecto.Codigo_pro LIKE'" + txtId.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.gvDonacion.DataSource = dt;
            gvDonacion.DataBind();
        }

        private void Solo_Lectura()
        {
            txtIdDonacion.ReadOnly = true;
            txtDonante.ReadOnly = true;
            txtProyecto.ReadOnly = true;
            txtMonto.ReadOnly = true;
            ddlEstado.Enabled = false;
        }

        private void Limpiar()
        {
            txtIdDonacion.Text = "";
            txtDonante.Text = "";
            txtProyecto.Text = "";
            txtMonto.Text = "";
        }

        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        Donaciones _donacion = new Donaciones();
        DonacionesBL _donacionesBL = new DonacionesBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            Solo_Lectura();
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
            txtDonante.Text = gvDonacion.Items[rowind].Cells[1].Text;
            txtProyecto.Text = gvDonacion.Items[rowind].Cells[2].Text;
            txtMonto.Text = gvDonacion.Items[rowind].Cells[3].Text;



            
            ddlEstado.Enabled = true;
        }

        protected void btnDonar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                _donacion.IdDonacion = Convert.ToInt64(txtIdDonacion.Text);
                _donacion.Estado = ddlEstado.Text;

                if (_donacion.IdDonacion != 0)
                {
                    _donacionesBL.ModificarDonacion_d(_donacion);
                    if (ddlEstado.SelectedIndex == 1)
                    {
                        string script = "alert('La donacion se ha realizado con exito')";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                        Obtener();
                        Limpiar();
                        Solo_Lectura();
                    }
                    else
                    {
                        string script = "alert('Ha ocurrido un error')";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    }
                    
                }
            }
            else
            {
                string script = "alert('Llene correctamente los campos')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            }
        }
    }
}