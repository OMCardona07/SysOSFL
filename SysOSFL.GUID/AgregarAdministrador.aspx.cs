using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysOSFL.EN;
using SysOSFL.BL;

namespace SysOSFL.GUID
{
    public partial class AgregarAdministrador : System.Web.UI.Page
    {
        Administrador _admin = new Administrador();
        JefeProject _jefe = new JefeProject();
        AdministradorBL _adminBL = new AdministradorBL();
        JefeProyectBL _jefeBL = new JefeProyectBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellidos.Text != "" && txtDui.Text != "" 
                && txtNomUsu.Text != "" && txtPass.Text != "")
            {
                if (ddCredencial.SelectedIndex == 0)
                {
                    _admin.Nombres = txtNombre.Text;
                    _admin.Apellidos = txtApellidos.Text;
                    _admin.Dui = txtDui.Text;
                    _admin.Telefono = txtTelefono.Text;
                    _admin.Email = txtEmail.Text;
                    _admin.NomUsu = txtNomUsu.Text;
                    _admin.Pass = txtPass.Text;
                    _admin.Credencial = ddCredencial.Text;

                    _adminBL.AgregarAdmin(_admin);
                    string script = "alert('El administrador se ha registrado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);

                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    txtDui.Text = "";
                    txtTelefono.Text = "";
                    txtEmail.Text = "";
                    txtNomUsu.Text = "";
                    txtPass.Text = "";
                }
                else
                {
                    _jefe.Nombres = txtNombre.Text;
                    _jefe.Apellidos = txtApellidos.Text;
                    _jefe.Dui = txtDui.Text;
                    _jefe.Telefono = txtTelefono.Text;
                    _jefe.Email = txtEmail.Text;
                    _jefe.NomUsu = txtNomUsu.Text;
                    _jefe.Pass = txtPass.Text;
                    _jefe.Credencial = ddCredencial.Text;

                    _jefeBL.AgregarJefe(_jefe);
                    string script = "alert('El jefe de proyecto se ha registrado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);

                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    txtDui.Text = "";
                    txtTelefono.Text = "";
                    txtEmail.Text = "";
                    txtNomUsu.Text = "";
                    txtPass.Text = "";
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