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
    public partial class RegistroDondante : System.Web.UI.Page
    {
        Donante _donante = new Donante();
        DonanteBL _donanteBL = new DonanteBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCredencial.Text = "Donante";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreEm.Text != "" && txtNrc.Text != "" && txtNomUsu.Text != "" && txtPass.Text != "")
            {
                _donante.NombreEm = txtNombreEm.Text;
                _donante.Nrc = txtNrc.Text;
                _donante.Telefono = txtTelefono.Text;
                _donante.Email = txtEmail.Text;
                _donante.NomUsu = txtNomUsu.Text;
                _donante.Pass = txtPass.Text;
                _donante.Credencial = txtCredencial.Text;

                _donanteBL.AgregarDonante(_donante);
                string script = "alert('El administrador se ha registrado exitosamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);

                txtNombreEm.Text = "";
                txtNrc.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
                txtNomUsu.Text = "";
                txtPass.Text = "";
            }
        }
    }
}