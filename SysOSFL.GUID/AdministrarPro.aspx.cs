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
    public partial class AdministrarPro : System.Web.UI.Page
    {
        private void Obtener()
        {
           SqlDataAdapter da = new SqlDataAdapter("SELECT Proyecto.IdProyecto, Proyecto.Codigo_pro, " +
               "Proyecto.Nombre, Proyecto.Tipo_pro,Proyecto.Presupuesto," +
               " (JefeProyect.Nombres+' '+JefeProyect.Apellidos) As Jefe, Proyecto.Progreso_pro " +
               "FROM Proyecto INNER JOIN JefeProyect ON Proyecto.idJefe = JefeProyect.Id" +
               " WHERE Proyecto.Codigo_pro LIKE'" + txtId.Text +"%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dgProyectos.DataSource = dt;
            dgProyectos.DataBind();
        }

        private void ObtenerTareas()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Bitacora.IdBitacora, Proyecto.Nombre, Bitacora.Nombre, Bitacora.Descripcion,Bitacora.Fecha_ini, Bitacora.Fecha_fin, Bitacora.Estado FROM Bitacora INNER JOIN Proyecto ON Bitacora.Id_pro = Proyecto.IdProyecto INNER JOIN JefeProyect ON JefeProyect.Id = Proyecto.idJefe WHERE Proyecto.Codigo_pro LIKE'" + txtId.Text+"%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dgTareas.DataSource = dt;
            dgTareas.DataBind();
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
                    }
                }
            }
        }

        public void LlenarComboPro()
        {
            if (!this.IsPostBack)
            {
                {
                    using (SqlCommand cmd = new SqlCommand("select IdProyecto, Nombre from Proyecto"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = cn;
                        cn.Open();
                        ddlProyecto.DataSource = cmd.ExecuteReader();
                        ddlProyecto.DataTextField = "Nombre";
                        ddlProyecto.DataValueField = "IdProyecto";
                        ddlProyecto.DataBind();
                        cn.Close();
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
        Tarea _tarea = new Tarea();
        TareaBL _tareaBL = new TareaBL();

        string id;
        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            LlenarComboPro();
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            int rowind = ((DataGridItem)(sender as Control).NamingContainer).ItemIndex;
            id = dgProyectos.Items[rowind].Cells[0].Text;
            txtCodigo.Text = dgProyectos.Items[rowind].Cells[1].Text;
            txtNombre_pro.Text = dgProyectos.Items[rowind].Cells[2].Text;
            txtTipo.Text = dgProyectos.Items[rowind].Cells[3].Text;
            txtPresupuesto.Text = dgProyectos.Items[rowind].Cells[4].Text;
            txtProgreso.Text = dgProyectos.Items[rowind].Cells[6].Text;
            txtId_pro.Text = dgProyectos.Items[rowind].Cells[0].Text;

            txtCodigo.ReadOnly = false;
            txtNombre_pro.ReadOnly = false;
            txtTipo.ReadOnly = false;
            txtPresupuesto.ReadOnly = false;
            txtProgreso.ReadOnly = false;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre_pro.Text != "" && txtTipo.Text != ""
                && txtPresupuesto.Text != "" && txtProgreso.Text != "")
            {
                _pro.IdProyecto = Convert.ToInt64(txtId_pro.Text);
                _pro.Codigo_pro = txtCodigo.Text;
                _pro.NombreProyecto = txtNombre_pro.Text;
                _pro.TipoProyecto = txtTipo.Text;
                _pro.PresupuestoProyecto = txtPresupuesto.Text;
                _pro.JefeProyecto = Convert.ToInt32(ddlJefe.SelectedValue);
                _pro.ProgresoProyecto = txtProgreso.Text;

                if (_pro.IdProyecto != 0)
                {
                    _proBL.ModificarPro(_pro);
                    string script = "alert('El Proyecto se ha modificado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    Limpiar();
                    Solo_Lectura();
                }


            }
            else
            {
                string script = "alert('Complete los datos correctamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Aceptar", script, true);
            }
        }

        protected void btnDeta_Ta_Click(object sender, EventArgs e)
        {
            int rowind = ((DataGridItem)(sender as Control).NamingContainer).ItemIndex;
            id = dgTareas.Items[rowind].Cells[0].Text;
            txtNombre_ta.Text = dgTareas.Items[rowind].Cells[2].Text;
            txtDesc.Text = dgTareas.Items[rowind].Cells[3].Text;
            txtFechaIni.Text = dgTareas.Items[rowind].Cells[4].Text;
            txtFechaFin.Text = dgTareas.Items[rowind].Cells[5].Text;
            txtId_tar.Text = dgTareas.Items[rowind].Cells[0].Text;

            //txtCodigo.ReadOnly = false;
            //txtNombre_pro.ReadOnly = false;
            //txtTipo.ReadOnly = false;
            //txtPresupuesto.ReadOnly = false;
            //txtProgreso.ReadOnly = false;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Obtener();
                ObtenerTareas();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            _pro.IdProyecto = Convert.ToInt64(txtId_pro.Text);

            if (_pro.IdProyecto != 0)
            {
                _proBL.eliminarPro(_pro.IdProyecto);
                string script = "alert('El Proyecto se ha eliminado exitosamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                Obtener();
                Limpiar();
                Solo_Lectura();
            }
        }

        protected void btnModificar_tar_Click(object sender, EventArgs e)
        {
            if (txtNombre_ta.Text != "" )
            {
                _tarea.IdTarea = Convert.ToInt64(txtId_tar.Text);
                _tarea.Id_pro = Convert.ToInt32(ddlProyecto.SelectedValue);
                _tarea.Nombre = txtNombre_ta.Text;
                _tarea.Descripcion = txtDesc.Text;
                _tarea.Fecha_ini = txtFechaIni.Text;
                _tarea.Fecha_fin = txtFechaFin.Text;
                _tarea.Estado = ddlEstado.Text;

                if (_tarea.IdTarea != 0)
                {
                    _tareaBL.ModificarTarea(_tarea);
                    string script = "alert('La Taear se ha modificado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    txtNombre_ta.Text = Convert.ToString(_tarea.IdTarea); 
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