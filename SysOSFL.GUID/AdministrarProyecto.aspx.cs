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
    public partial class AdministrarProyecto : System.Web.UI.Page
    {
        private void Obtener()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Proyecto.IdProyecto, Proyecto.Codigo_pro, " +
                "Proyecto.Nombre, Proyecto.Tipo_pro,Proyecto.Presupuesto," +
                " (JefeProyect.Nombres+' '+JefeProyect.Apellidos) As Jefe, Proyecto.Progreso_pro " +
                "FROM Proyecto INNER JOIN JefeProyect ON Proyecto.idJefe = JefeProyect.Id" +
                " WHERE Proyecto.Codigo_pro LIKE'" + txtId.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dgProyectos.DataSource = dt;
            dgProyectos.DataBind();
        }

        public void LlenarCombo()
        {
            if (!this.IsPostBack)
            {
                {
                    using (SqlCommand cmd = new SqlCommand("select Id, Nombres+' '+Apellidos as Jefe from JefeProyect where Id > 0"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = cn;
                        cn.Open();
                        ddlJefe.DataSource = cmd.ExecuteReader();
                        ddlJefe.DataTextField = "Jefe";
                        ddlJefe.DataValueField = "Id";
                        ddlJefe.DataBind();
                        cn.Close();
                        ddlJefe.Items.Insert(0, "--SELECCIONE UN JEFE--");
                    }
                }
            }
        }



        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre_pro.Text = "";
            txtTipo.Text = "";
            txtPresupuesto.Text = "";
            txtProgreso.Text = "";
            txtId_pro.Text = "";
        }

        private void Solo_Lectura()
        {
            txtCodigo.ReadOnly = true;
            txtNombre_pro.ReadOnly = true;
            txtTipo.ReadOnly = true;
            txtPresupuesto.ReadOnly = true;
            txtProgreso.ReadOnly = true;
            txtId_pro.ReadOnly = true;
        }

        ProyectosEN _pro = new ProyectosEN();
        ProyectosBL _proBL = new ProyectosBL();

        string id;
        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarCombo();
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
            //id = dgProyectos.Items[rowind].Cells[0].Text;
            txtCodigo.Text = dgProyectos.Items[rowind].Cells[1].Text;
            txtNombre_pro.Text = dgProyectos.Items[rowind].Cells[2].Text;
            txtTipo.Text = dgProyectos.Items[rowind].Cells[3].Text;
            txtPresupuesto.Text = dgProyectos.Items[rowind].Cells[4].Text;
            txtProgreso.Text = dgProyectos.Items[rowind].Cells[6].Text;
            txtId_pro.Text = dgProyectos.Items[rowind].Cells[0].Text;

            //txtCodigo.ReadOnly = false;
            //txtNombre_pro.ReadOnly = false;
            //txtTipo.ReadOnly = false;
            //txtPresupuesto.ReadOnly = false;
            //txtProgreso.ReadOnly = false;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                _pro.IdProyecto =Convert.ToInt64(txtId_pro.Text);
                _pro.Codigo_pro = txtCodigo.Text;
                _pro.NombreProyecto = txtNombre_pro.Text;
                _pro.TipoProyecto = txtTipo.Text;
                _pro.PresupuestoProyecto = txtPresupuesto.Text;
                _pro.JefeProyecto = Convert.ToInt32(ddlJefe.SelectedValue);
                _pro.ProgresoProyecto = txtProgreso.Text;

                if (_pro.IdProyecto != 0)
                {
                    _proBL.ModificarPro(_pro);
                    string script = "alert('La Tarea se ha modificado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    //txtCodigo.Text = Convert.ToString(_pro.IdProyecto);
                    //Limpiar();
                    Solo_Lectura();
                }
            }
            else
            {
                string script = "alert('Complete los datos correctamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Aceptar", script, true);
            }
        }

        protected void btnAcTarea_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdministrarTarea.aspx");
        }
    }
}