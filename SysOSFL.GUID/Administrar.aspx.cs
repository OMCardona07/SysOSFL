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
    public partial class Administrar : System.Web.UI.Page
    {
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDui.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNomUsu.Text = "";
            txtPass.Text = "";
            txtId.Text = "";
        }

        private void Solo_Lectura()
        {
            txtIdAdmin.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellidos.ReadOnly = true;
            txtDui.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtNomUsu.ReadOnly = true;
            txtPass.ReadOnly = true; ;
        }

        private void Obtener()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Administrador WHERE Dui LIKE'" + txtId.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.gvUsuarios.DataSource = dt;
            gvUsuarios.DataBind();
        }

        AdministradorBL _adminBL = new AdministradorBL();
        Administrador _admin = new Administrador();
        string id;
        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = BDSysOSFDL; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            Solo_Lectura();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
            List<Administrador> list = new List<Administrador>();
            
            if (txtId.Text != "")
            {
                Obtener();
            }
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            int rowind = ((DataGridItem)(sender as Control).NamingContainer).ItemIndex;
            id = gvUsuarios.Items[rowind].Cells[0].Text;
            txtNombre.Text = gvUsuarios.Items[rowind].Cells[1].Text;
            txtApellidos.Text = gvUsuarios.Items[rowind].Cells[2].Text;
            txtDui.Text = gvUsuarios.Items[rowind].Cells[3].Text;
            txtEmail.Text = gvUsuarios.Items[rowind].Cells[4].Text;
            txtTelefono.Text = gvUsuarios.Items[rowind].Cells[5].Text;
            txtNomUsu.Text = gvUsuarios.Items[rowind].Cells[6].Text;
            txtPass.Text = gvUsuarios.Items[rowind].Cells[7].Text;
            txtIdAdmin.Text = gvUsuarios.Items[rowind].Cells[0].Text;

            txtNombre.ReadOnly = false;
            txtApellidos.ReadOnly = false;
            txtDui.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtNomUsu.ReadOnly = false;
            txtPass.ReadOnly = false;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                _admin.IdAdmin = Convert.ToInt64(txtIdAdmin.Text);
                _admin.Nombres = txtNombre.Text;
                _admin.Apellidos = txtApellidos.Text;
                _admin.Dui = txtDui.Text;
                _admin.Email = txtEmail.Text;
                _admin.Telefono = txtTelefono.Text;
                _admin.NomUsu = txtNomUsu.Text;
                _admin.Pass = txtPass.Text;

                if (_admin.IdAdmin != 0)
                {
                    _adminBL.ModificarAdministrador(_admin);
                    Obtener();
                    Limpiar();
                    Solo_Lectura();
                }



            }
            else { }
        }

        protected void btnEliminar_Click1(object sender, EventArgs e)
        {
            _admin.IdAdmin = Convert.ToInt64(txtIdAdmin.Text);

            if (_admin.IdAdmin != 0)
            {
                _adminBL.EliminarAdministracion(_admin.IdAdmin);
                Obtener();
                Limpiar();
                Solo_Lectura();
            }
        }
    }
}