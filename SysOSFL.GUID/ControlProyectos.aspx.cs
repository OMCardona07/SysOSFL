using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysOSFL.BL;
using SysOSFL.EN;

namespace SysOSFL.GUID
{
    
    public partial class ControlProyectos : System.Web.UI.Page
    {
        ProyectosEN _Proyecto = new ProyectosEN();
        ProyectosBL _ProyectoBL = new ProyectosBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha registrado exitosamente')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtNombre_pro.Text != "" && txtTipo.Text != "" && txtCodigo.Text != "" && txtProgreso.Text != "")
            {
                ProyectosEN Proyec = new ProyectosEN();
                Proyec.NombreProyecto = txtNombre_pro.Text;
                Proyec.TipoProyecto = txtTipo.Text;
                Proyec.IdProyecto = txtCodigo.Text;
                Proyec.ProgresoProyecto = txtProgreso.Text;

                _ProyectoBL.AgregarPro(Proyec);

                txtNombre_pro.Text = "";
                txtTipo.Text = "";
                txtCodigo.Text = "";
                txtProgreso.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha eliminado exitosamente')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtCodigo.Text != "")
            {
                ProyectosEN Proyec = new ProyectosEN();

                Proyec.IdProyecto = txtCodigo.Text;
                _ProyectoBL.eliminarPro(Proyec);


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
            if (txtNombre_pro.Text != "" && txtTipo.Text != "" && txtCodigo.Text != "" && txtProgreso.Text != "")
            {
                ProyectosEN Proyec = new ProyectosEN();
                Proyec.NombreProyecto = txtNombre_pro.Text;
                Proyec.TipoProyecto = txtTipo.Text;
                Proyec.IdProyecto = txtCodigo.Text;
                Proyec.ProgresoProyecto = txtProgreso.Text;

                _ProyectoBL.ModificarPro(Proyec);



                txtNombre_pro.Text = "";
                txtTipo.Text = "";
                txtCodigo.Text = "";
                txtProgreso.Text = "";

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha encontrado')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtCodigo.Text != "")
            {
                ProyectosEN Proyec = new ProyectosEN();

                Proyec.IdProyecto = txtCodigo.Text;



                txtCodigo.Text = "";


                this.GridView1.DataSource = _ProyectoBL.buscarProyec(Proyec); ;
                GridView1.DataBind();
            }
    }
}