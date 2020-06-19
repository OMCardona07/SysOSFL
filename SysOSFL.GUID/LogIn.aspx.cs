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
    public partial class LogIn : System.Web.UI.Page
    {
        AdministradorBL _adminBL = new AdministradorBL();
        Administrador _admin = new Administrador();
        JefeProyectBL _jefeBL = new JefeProyectBL();
        DonanteBL _donanteBL = new DonanteBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            if (ddCredencial.SelectedIndex == 0)
            {
                //_admin.NomUsu = txtNomUsu.Text;
                //_admin.Pass = txtPass.Text;
                if (_adminBL.BuscarAdmin(txtNomUsu.Text, txtPass.Text) == 1)
                {
                    Response.Redirect("~/IndexAdmin.aspx");
                }
                else
                {
                    string script = "alert('Complete los datos correctamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Aceptar", script, true);
                }
            }

            if (ddCredencial.SelectedIndex == 1)
            {
                if (_jefeBL.BuscarJefe(txtNomUsu.Text, txtPass.Text) == 1)
                {
                    Response.Redirect("~/IndexJefe.aspx");
                }
                else
                {
                    string script = "alert('Complete los datos correctamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Aceptar", script, true);
                }
            }

            if (ddCredencial.SelectedIndex == 2)
            {
                if (_donanteBL.BuscarDonante(txtNomUsu.Text, txtPass.Text) == 1)
                {
                    Response.Redirect("~/IndexDonante.aspx");
                }
                else
                {
                    string script = "alert('Complete los datos correctamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Aceptar", script, true);
                }
            }
        }
    }
}