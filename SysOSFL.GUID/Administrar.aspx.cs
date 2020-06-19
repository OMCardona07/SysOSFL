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
            txtIdUsu.Text = "";
            txtCredencial.Text = "";
        }

        private void Solo_Lectura()
        {
            txtIdUsu.ReadOnly = true;
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Administrador WHERE Dui LIKE'" + txtId.Text + "%'UNION" +
                " SELECT * FROM JefeProyect WHERE Dui LIKE'" + txtId.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.gvUsuarios.DataSource = dt;
            gvUsuarios.DataBind();
        }

        AdministradorBL _adminBL = new AdministradorBL();
        Administrador _admin = new Administrador();
        JefeProject _jefe = new JefeProject();
        JefeProyectBL _jefeBL = new JefeProyectBL();

        string id;
        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = SysOSFL; Integrated Security = True");

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
            txtCredencial.Text = gvUsuarios.Items[rowind].Cells[8].Text;
            txtIdUsu.Text = gvUsuarios.Items[rowind].Cells[0].Text;

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
            if (txtNombre.Text != "" && txtApellidos.Text != "" && txtDui.Text != ""
                && txtNomUsu.Text != "" && txtPass.Text != "")
            {
                if (txtCredencial.Text == "Administrador")
                {
                    _admin.Nombres = txtNombre.Text;
                    _admin.Apellidos = txtApellidos.Text;
                    _admin.Dui = txtDui.Text;
                    _admin.Telefono = txtTelefono.Text;
                    _admin.Email = txtEmail.Text;
                    _admin.NomUsu = txtNomUsu.Text;
                    _admin.Pass = txtPass.Text;
                    _admin.Credencial = txtCredencial.Text;
                    _admin.IdAdmin = Convert.ToInt64(txtIdUsu.Text);

                    _adminBL.ModificarAdministrador(_admin);
                    string script = "alert('El administrador se ha modificado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    Limpiar();
                    Solo_Lectura();
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
                    _jefe.Credencial = txtCredencial.Text;
                    _jefe.IdJefeProyect = Convert.ToInt64(txtIdUsu.Text);

                    _jefeBL.ModificarJefe(_jefe);
                    string script = "alert('El jefe de proyecto se ha modificado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    Limpiar();
                    Solo_Lectura();
                }
            }
            else
            {
                string script = "alert('Complete los datos correctamente')";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Aceptar", script, true);
            }
        }

        protected void btnEliminar_Click1(object sender, EventArgs e)
        {
            _admin.IdAdmin = Convert.ToInt64(txtIdUsu.Text);
            _jefe.IdJefeProyect = Convert.ToInt64(txtIdUsu.Text);

            if (txtCredencial.Text == "Administrador")
            {
                if (_admin.IdAdmin != 0)
                {
                    _adminBL.EliminarAdministracion(_admin.IdAdmin);
                    string script = "alert('El donante se ha eliminado exitosamente')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    Limpiar();
                    Solo_Lectura();
                }

            }
            else
            {
                if (_jefe.IdJefeProyect != 0)
                {
                    _jefeBL.EliminarJefe(_jefe.IdJefeProyect);
                    string script = "alert('El donante No se ha eliminado')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Exito", script, true);
                    Obtener();
                    Limpiar();
                    Solo_Lectura();
                }
            }
        }
    }
}