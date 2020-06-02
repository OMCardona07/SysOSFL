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
        public SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = BDSysOSFDL; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            AdministradorBL adminBL = new AdministradorBL();
            Administrador obj = new Administrador();
            List<Administrador> list = new List<Administrador>();
            
            if (txtId.Text != "")
            {

                //obj = adminBL.ObtenerAdministracionporId(Convert.ToInt64(txtId.Text));
                //list.Add(obj);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Administrador WHERE Dui LIKE'"+txtId.Text +"%'",cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                this.gvUsuarios.DataSource = dt;
                gvUsuarios.DataBind();
            }
        }
    }
}