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
    public partial class AgregarTareas : System.Web.UI.Page
    {
        public void LlenarCombo()
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

        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        Tarea tarea = new Tarea();
        TareaBL _tareaBL = new TareaBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        protected void btnGuardarPro_Click(object sender, EventArgs e)
        {
            if (txtNombre_ta.Text != "" && txtDesc.Text != "" && txtFechaIni.Text != "" &&
                txtFechaFin.Text != "")
            {
                
                tarea.Id_pro = Convert.ToInt32(ddlProyecto.SelectedValue);
                tarea.Nombre = txtNombre_ta.Text;
                tarea.Descripcion = txtDesc.Text;
                tarea.Fecha_ini = txtFechaIni.Text;
                tarea.Fecha_fin = txtFechaFin.Text;
                tarea.Estado = ddlEstado.Text;



                _tareaBL.AgregarTarea(tarea);
                string script = "alert('Se ha registrado exitosamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            }
            else
            {
                string script = "alert('El proyecto no se ha podido guardar')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            }
        }
    }
}