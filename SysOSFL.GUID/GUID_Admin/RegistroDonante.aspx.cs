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
    public partial class RegistroDonante : System.Web.UI.Page
    {
        Donante _donante = new Donante();
        DonanteBL _donanteBL = new DonanteBL();

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtNrc.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNomUsu.Text = "";
            txtPass.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCredencial.Text = "Donante";
            txtCredencial.ReadOnly = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNrc.Text != ""
                && txtNomUsu.Text != "" && txtPass.Text != "" && txtCredencial.Text != "")
            {
                _donante.NombreEm = txtNombre.Text;
                _donante.Nrc = txtNrc.Text;
                _donante.Telefono = txtTelefono.Text;
                _donante.Email = txtEmail.Text;
                _donante.NomUsu = txtNomUsu.Text;
                _donante.Pass = txtPass.Text;
                _donante.Credencial = txtCredencial.Text;

                _donanteBL.AgregarDonante(_donante);
                MessageBox.Show("EL DONANTE SE HA REGISTRADO CORRECTAMENTE");
                Limpiar();
            }
        }
    }
}