using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysOSFL.BL;
using SysOSFL.EN;
using System.Data.SqlClient;
using System.Data;


namespace SysOSFL.GUID
{
    public partial class AdministrarDonante : System.Web.UI.Page
    {
        private void Limpiar()
        {
            txtNombreEm.Text = "";
            txtNrc.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNomUsu.Text = "";
            txtPass.Text = "";
            txtId.Text = "";
            txtCredencial.Text = "";
            txtIdDonante.Text = "";
        }

        private void Solo_Lectura()
        {
            txtIdDonante.ReadOnly = true;
            txtNombreEm.ReadOnly = true;
            txtNrc.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtNomUsu.ReadOnly = true;
            txtPass.ReadOnly = true; ;
        }

        private void Obtener()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Donante WHERE N_Emp LIKE'" + txtId.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.gvDonante.DataSource = dt;
            gvDonante.DataBind();
        }

        Donante _donante = new Donante();
        DonanteBL _donanteBL = new DonanteBL();
        string id;
        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Solo_Lectura();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Obtener();
            }
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            int rowind = ((DataGridItem)(sender as Control).NamingContainer).ItemIndex;
            id = gvDonante.Items[rowind].Cells[0].Text;
            txtNombreEm.Text = gvDonante.Items[rowind].Cells[1].Text;
            txtNrc.Text = gvDonante.Items[rowind].Cells[2].Text;
            txtEmail.Text = gvDonante.Items[rowind].Cells[3].Text;
            txtTelefono.Text = gvDonante.Items[rowind].Cells[4].Text;
            txtNomUsu.Text = gvDonante.Items[rowind].Cells[5].Text;
            txtPass.Text = gvDonante.Items[rowind].Cells[6].Text;
            txtCredencial.Text = gvDonante.Items[rowind].Cells[7].Text;
            txtIdDonante.Text = gvDonante.Items[rowind].Cells[0].Text;

            txtNombreEm.ReadOnly = false;
            txtNrc.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtNomUsu.ReadOnly = false;
            txtPass.ReadOnly = false;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreEm.Text != "")
            {
                _donante.IdDonante = Convert.ToInt64(txtIdDonante.Text);
                _donante.NombreEm = txtNombreEm.Text;
                _donante.Nrc = txtNrc.Text;
                _donante.Email = txtEmail.Text;
                _donante.Telefono = txtTelefono.Text;
                _donante.NomUsu = txtNomUsu.Text;
                _donante.Pass = txtPass.Text;
                _donante.Credencial = txtCredencial.Text;

                if (_donante.IdDonante != 0)
                {
                    _donanteBL.ModificarDonante(_donante);
                    string script = "alert('El donante se ha modificado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    Limpiar();
                    Solo_Lectura();
                }
            }
            else { }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            _donante.IdDonante = Convert.ToInt64(txtIdDonante.Text);

            if (_donante.IdDonante != 0)
            {
                _donanteBL.EliminarDonante(_donante.IdDonante);
                string script = "alert('El donante se ha eliminado exitosamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                Obtener();
                Limpiar();
                Solo_Lectura();
            }
        }
    }
}