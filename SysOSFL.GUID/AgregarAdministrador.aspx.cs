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
        AdministradorBL _adminBL = new AdministradorBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellidos.Text != "" && txtDui.Text != "" && txtNomUsu.Text != "" && txtPass.Text != "")
            {
                _admin.Nombres = txtNombre.Text;
                _admin.Apellidos = txtApellidos.Text;
                _admin.Dui = txtDui.Text;
                _admin.Telefono = txtTelefono.Text;
                _admin.Email = txtEmail.Text;
                _admin.NomUsu = txtNomUsu.Text;
                _admin.Pass = txtPass.Text;

                _adminBL.AgregarAdmin(_admin);
                string script = "alert('Se ha registrado exitosamente')";
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
                string script = "alert('Complete los datos correctamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Aceptar", script, true);
            }
        }
    }
}