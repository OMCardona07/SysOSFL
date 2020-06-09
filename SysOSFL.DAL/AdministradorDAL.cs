using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SysOSFL.EN;

namespace SysOSFL.DAL
{
    public class AdministradorDAL
    {
        public int AgregarAdmin(Administrador pAdmin)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("INSERT INTO Administrador(Nombres_A,Apellidos_A,Dui_A," +
                "Email_A,Telefono_A,NomUsu_A,Pass_A,Credencial_A)" +
                " Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                pAdmin.Nombres, pAdmin.Apellidos, pAdmin.Dui, pAdmin.Email, pAdmin.Telefono, pAdmin.NomUsu, pAdmin.Pass, pAdmin.Credencial), _conn);
            int resultado = comando.ExecuteNonQuery();

            _conn.Close();
            return resultado;
        }

        public static int ModificarAdministracion(Administrador pAdmin)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                string _Sql = "UPDATE Administrador SET Nombres_A=@Nombres_A,Apellidos_A=@Apellidos_A,Dui_A=@Dui_A,Email_A=@Email_A," +
                    " Telefono_A=@Telefono_A,NomUsu_A=@NomUsu_ANomUsu_A,Pass_A=@Pass_A,Credencial_A=@Credencial_A WHERE IdAdmin=@IdAdmin";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@IdAdmin", pAdmin.IdAdmin);
                comando.Parameters.AddWithValue("@Nombres_A", pAdmin.Nombres);
                comando.Parameters.AddWithValue("@Apellidos_A", pAdmin.Apellidos);
                comando.Parameters.AddWithValue("@Dui_A", pAdmin.Dui);
                comando.Parameters.AddWithValue("@Email_A", pAdmin.Email);
                comando.Parameters.AddWithValue("@Telefono_A", pAdmin.Telefono);
                comando.Parameters.AddWithValue("@NomUsu_A", pAdmin.NomUsu);
                comando.Parameters.AddWithValue("@Pass_A", pAdmin.Pass);
                comando.Parameters.AddWithValue("@Credencial_A", pAdmin.Credencial);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }


        }

        public int EliminarAdministrador(Int64 pIdAdmin)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("DELETE FROM Administrador WHERE IdAdmin = {0}", pIdAdmin)
                , _conn);
            int resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }

        public List<Administrador> ObtenerAdministradores()
        {
            List<Administrador> _listaAdministracion = new List<Administrador>();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos("select * from Administrador", _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    Administrador obj = new Administrador();
                    obj.IdAdmin = reader.GetInt64(0);
                    obj.Nombres = reader.GetString(1);
                    obj.Apellidos = reader.GetString(2);
                    obj.Dui = reader.GetString(3);
                    obj.Email = reader.GetString(4);
                    obj.Telefono = reader.GetString(5);
                    obj.NomUsu = reader.GetString(6);
                    obj.Pass = reader.GetString(7);
                    obj.Credencial = reader.GetString(8);

                    _listaAdministracion.Add(obj);

                }
                _conn.Close();
                return _listaAdministracion;
            }
        }

        public Administrador ObtenerAdministracionporId(Int64 pIdAdministrador)
        {
            Administrador obj = new Administrador();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos(string.Format("select * from Administrador where IdAdmin={0}", pIdAdministrador), _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    ////obj.IdAdmin = reader.GetInt64(0);
                    obj.Nombres = reader.GetString(1);
                    obj.Apellidos = reader.GetString(2);
                    obj.Dui = reader.GetString(3);
                    obj.Email = reader.GetString(4);
                    obj.Telefono = reader.GetString(5);
                    obj.NomUsu = reader.GetString(6);
                    obj.Pass = reader.GetString(7);
                    obj.Credencial = reader.GetString(8);
                }
                _conn.Close();
            }
            return obj;
        }
    }
}
