using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysOSFL.BL;
using SysOSFL.EN;
using System.Data;
using System.Data.SqlClient;

namespace SysOSFL.GUID
{
    
    public partial class ControlProyectos : System.Web.UI.Page
    {
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

        JefeProyectBL _jefeBL = new JefeProyectBL();
        ProyectosEN _Proyecto = new ProyectosEN();
        ProyectosBL _ProyectoBL = new ProyectosBL();
        TareaBL _tareaBL = new TareaBL();
        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            LlenarComboPro();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtNombre_pro.Text != "" && txtTipo.Text != "" && txtCodigo.Text != "" &&
                txtProgreso.Text != "" && txtPresupuesto.Text != "")
            {
                ProyectosEN Proyec = new ProyectosEN();
                Proyec.Codigo_pro = txtCodigo.Text;
                Proyec.NombreProyecto = txtNombre_pro.Text;
                Proyec.TipoProyecto = txtTipo.Text;
                Proyec.PresupuestoProyecto = txtPresupuesto.Text;
                Proyec.JefeProyecto = Convert.ToInt32(ddlJefe.SelectedValue);
                Proyec.ProgresoProyecto = txtProgreso.Text;



                _ProyectoBL.AgregarPro(Proyec);
                //Response.Redirect(Page.Request.Path);
                string script = "alert('Se ha registrado exitosamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                Page.Response.Redirect(Page.Request.Url.ToString(), true);

                //Page_Load(sender, e);


                txtNombre_pro.Text = "";
                txtTipo.Text = "";
                txtCodigo.Text = "";
                txtProgreso.Text = "";
                txtPresupuesto.Text = "";
            }
            else
            {
                string script = "alert('El proyecto no se ha podido guardar')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha eliminado exitosamente')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtCodigo.Text != "")
            {
                ProyectosEN Proyec = new ProyectosEN();

                //Proyec.IdProyecto = txtCodigo.Text;
                //_ProyectoBL.eliminarPro(Proyec);


                txtCodigo.Text = "";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string script = "alert('Lista de proyectos')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);

            this.GridView1.DataSource = _ProyectoBL.ObtenerPro();
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha modificado exitosamente')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtNombre_pro.Text != "" && txtTipo.Text != "" && txtCodigo.Text != "" && txtProgreso.Text != "" && txtPresupuesto.Text != "")
            {
                ProyectosEN Proyec = new ProyectosEN();
                Proyec.NombreProyecto = txtNombre_pro.Text;
                Proyec.TipoProyecto = txtTipo.Text;
                //Proyec.IdProyecto = txtCodigo.Text;
                Proyec.ProgresoProyecto = txtProgreso.Text;
                Proyec.PresupuestoProyecto = txtPresupuesto.Text;
                //Proyec.JefeProyecto = txtJefe.Text;

                _ProyectoBL.ModificarPro(Proyec);



                txtNombre_pro.Text = "";
                txtTipo.Text = "";
                txtCodigo.Text = "";
                txtProgreso.Text = "";
                txtPresupuesto.Text = "";
                //txtJefe.Text = "";

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha encontrado')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtCodigo.Text != "")
            {
                ProyectosEN Proyec = new ProyectosEN();

               /* Proyec.IdProyecto = txtCodigo.Text*/;



                txtCodigo.Text = "";


                this.GridView1.DataSource = _ProyectoBL.buscarProyec(Proyec); ;
                GridView1.DataBind();
            }
    }

        protected void btnGuardarPro_Click(object sender, EventArgs e)
        {
            if (txtNombre_ta.Text != "" && txtDesc.Text != "" && txtFechaIni.Text != "" &&
                txtFechaFin.Text != "")
            {
                Tarea tarea = new Tarea();
                tarea.Id_pro = Convert.ToInt32(ddlProyecto.SelectedValue);
                tarea.Nombre = txtNombre_ta.Text;
                tarea.Descripcion = txtDesc.Text;
                tarea.Fecha_ini = txtFechaIni.Text;
                tarea.Fecha_fin = txtFechaFin.Text;
                tarea.Estado = ddlEstado.Text;



                _tareaBL.AgregarTarea(tarea);
                string script = "alert('Se ha registrado exitosamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);

                txtNombre_pro.Text = "";
                txtTipo.Text = "";
                txtCodigo.Text = "";
                txtProgreso.Text = "";
                txtPresupuesto.Text = "";
            }
            else
            {
                string script = "alert('El proyecto no se ha podido guardar')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            }
        }
    }
}