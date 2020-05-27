using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysOSFL.DAL
{
    class BDComun
    {
        private static string _conn = @"Data Source=.;Initial Catalog=BDSysOSFDL;Integrated Security=True";
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_conn);
        }
        public static IDbCommand ObtenerComandos(string pSQL, IDbConnection pConn)
        {
            return new SqlCommand(pSQL, pConn as SqlConnection);
        }
    }
}
