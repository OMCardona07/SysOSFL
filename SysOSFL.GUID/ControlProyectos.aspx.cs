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
                        ddlJefe.Items.Insert(0, "--SELECCIONE UN JEFE--");
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

        protected void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AgregarTareas.aspx");
        }
    }
}