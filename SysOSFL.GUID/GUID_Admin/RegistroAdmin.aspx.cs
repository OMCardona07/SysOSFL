using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysOSFL.EN;
using SysOSFL.BL;
using System.Windows.Forms;

namespace SysOSFL.GUID.GUID_Admin
{
    public partial class RegistroAdmin : System.Web.UI.Page
    {
        Administrador _admin = new Administrador();
        AdministradorBL _adminBL = new AdministradorBL();

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDui.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNomUsu.Text = "";
            txtPass.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCredencial.Text = "Administrador";
            txtCredencial.ReadOnly = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellidos.Text != "" && txtDui.Text != ""
                && txtNomUsu.Text != "" && txtPass.Text != "" && txtCredencial.Text != "")
            {
                _admin.Nombres = txtNombre.Text;
                _admin.Apellidos = txtApellidos.Text;
                _admin.Dui = txtDui.Text;
                _admin.Telefono = txtTelefono.Text;
                _admin.Email = txtEmail.Text;
                _admin.NomUsu = txtNomUsu.Text;
                _admin.Pass = txtPass.Text;
                _admin.Credencial = txtCredencial.Text;

                _adminBL.AgregarAdmin(_admin);
                MessageBox.Show("EL ADMINISTRADOR SE HA REGISTRADO CORRECTAMENTE");
                Limpiar();
            }
        }
    }
}