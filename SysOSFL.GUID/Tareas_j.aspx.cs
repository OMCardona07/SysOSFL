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
    public partial class Tareas_j : System.Web.UI.Page
    {
        private void Obtener()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Bitacora.IdBitacora, Proyecto.Nombre, Bitacora.Nombre_bi, Bitacora.Descripcion,Bitacora.Fecha_ini, Bitacora.Fecha_fin, Bitacora.Estado FROM Bitacora INNER JOIN Proyecto ON Bitacora.Id_pro = Proyecto.IdProyecto INNER JOIN JefeProyect ON JefeProyect.Id = Proyecto.idJefe WHERE Proyecto.Codigo_pro LIKE'" + txtId.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dgTareas.DataSource = dt;
            dgTareas.DataBind();
        }

        private void Limpiar()
        {
            txtId_tar.Text = "";
            txtNombre_ta.Text = "";
            txtDesc.Text = "";
            txtFechaIni.Text = "";
            txtFechaFin.Text = "";
            txtProyecto.Text = "";
        }

        private void Solo_Lectura()
        {
            txtId_tar.ReadOnly = true;
            txtNombre_ta.ReadOnly = true;
            txtDesc.ReadOnly = true;
            txtFechaIni.ReadOnly = true;
            txtFechaFin.ReadOnly = true;
            txtProyecto.ReadOnly = true;
            ddlEstado.Enabled = false;
        }

        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        Tarea _tarea = new Tarea();
        TareaBL _tareaBL = new TareaBL();

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
            //id = dgTareas.Items[rowind].Cells[0].Text;
            txtNombre_ta.Text = dgTareas.Items[rowind].Cells[2].Text;
            txtProyecto.Text = dgTareas.Items[rowind].Cells[1].Text;
            txtDesc.Text = dgTareas.Items[rowind].Cells[3].Text;
            txtFechaIni.Text = dgTareas.Items[rowind].Cells[4].Text;
            txtFechaFin.Text = dgTareas.Items[rowind].Cells[5].Text;
            txtId_tar.Text = dgTareas.Items[rowind].Cells[0].Text;

            
            ddlEstado.Enabled = true;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre_ta.Text != "")
            {
                _tarea.IdTarea = Convert.ToInt64(txtId_tar.Text);
                _tarea.Estado = ddlEstado.Text;

                if (_tarea.IdTarea != 0)
                {
                    _tareaBL.ModificarTarea_J(_tarea);
                    string script = "alert('La Tarea se ha modificado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
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
    }
}