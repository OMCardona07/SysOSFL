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
    public partial class RegistroJefe : System.Web.UI.Page
    {
        JefeProject _jefe = new JefeProject();
        JefeProyectBL _jefeBL = new JefeProyectBL();

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
            txtCredencial.Text = "Jefe de proyecto";
            txtCredencial.ReadOnly = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellidos.Text != "" && txtDui.Text != ""
                && txtNomUsu.Text != "" && txtPass.Text != "" && txtCredencial.Text != "")
            {
                _jefe.Nombres = txtNombre.Text;
                _jefe.Apellidos = txtApellidos.Text;
                _jefe.Dui = txtDui.Text;
                _jefe.Telefono = txtTelefono.Text;
                _jefe.Email = txtEmail.Text;
                _jefe.NomUsu = txtNomUsu.Text;
                _jefe.Pass = txtPass.Text;
                _jefe.Credencial = txtCredencial.Text;

                _jefeBL.AgregarJefe(_jefe);
                MessageBox.Show("EL JEFE DE PROYECTO SE HA REGISTRADO CORRECTAMENTE");
                Limpiar();
            }
        }
    }
}