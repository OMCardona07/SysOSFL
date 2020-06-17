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
    public partial class RegistroBitacoras : System.Web.UI.Page
    {

        BitacorasEN _Proyecto = new BitacorasEN();
        BitacorasBL _ProyectoBL = new BitacorasBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha registrado exitosamente')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtCodigo_pro.Text != "" && txtCodigoBi.Text != "" && txtDes.Text != "" && txtFecha.Text != "")
            {
                BitacorasEN Proyec = new BitacorasEN();
                Proyec.CodigoProyecto = txtCodigo_pro.Text;
                Proyec.CodigoBi = txtCodigoBi.Text;
                Proyec.Descripcion = txtDes.Text;
                Proyec.Fecha = txtFecha.Text;


                _ProyectoBL.AgregarBi(Proyec);

                txtCodigo_pro.Text = "";
                txtCodigoBi.Text = "";
                txtDes.Text = "";
                txtFecha.Text = "";




            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha eliminado exitosamente')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtEl.Text != "")
            {
                BitacorasEN Proyec = new BitacorasEN();

                Proyec.CodigoBi = txtEl.Text;
                _ProyectoBL.eliminarBi(Proyec);


                txtEl.Text = "";



            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha encontrado')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (textPro.Text != "")
            {
                BitacorasEN Proyec = new BitacorasEN();

                Proyec.CodigoProyecto = textPro.Text;



                textPro.Text = "";


                this.GridView1.DataSource = _ProyectoBL.buscarBi(Proyec); ;
                GridView1.DataBind();




            }
        }



        protected void Button4_Click(object sender, EventArgs e)
        {
            string script = "alert('Se ha modificado exitosamente')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
            if (txtCodigo_pro.Text != "" && txtCodigoBi.Text != "" && txtDes.Text != "" && txtFecha.Text != "")
            {
                BitacorasEN Proyec = new BitacorasEN();
                Proyec.CodigoProyecto = txtCodigo_pro.Text;
                Proyec.CodigoBi = txtCodigoBi.Text;
                Proyec.Descripcion = txtDes.Text;
                Proyec.Fecha = txtFecha.Text;



                _ProyectoBL.ModificarBi(Proyec);


                txtCodigo_pro.Text = "";
                txtCodigoBi.Text = "";
                txtDes.Text = "";
                txtFecha.Text = "";


            }
        }



    }
}