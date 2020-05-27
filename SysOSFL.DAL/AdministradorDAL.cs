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
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("insert into Administrador(Nombres,Apellidos,Dui,Email,Telefono,NomUsu,Pass) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                pAdmin.Nombres, pAdmin.Apellidos, pAdmin.Dui, pAdmin.Email, pAdmin.Telefono, pAdmin.NomUsu, pAdmin.Pass), _conn);
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
                IDbCommand commando = BDComun.ObtenerComandos(string.Format("select * from Administracion where Id={0}", pIdAdministrador), _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    obj.IdAdmin = reader.GetInt64(0);
                    obj.Nombres = reader.GetString(1);
                    obj.Apellidos = reader.GetString(2);
                    obj.Dui = reader.GetString(3);
                    obj.Email = reader.GetString(4);
                    obj.Telefono = reader.GetString(5);
                    obj.NomUsu = reader.GetString(6);
                    obj.Pass = reader.GetString(7);
                }
                _conn.Close();
            }
            return obj;
        }

        public List<Administrador> ObtenerAdministracionporNombre(string pAdministrador)
        {
            List<Administrador> ListaAdministracion = new List<Administrador>();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos(string.Format("select * from Administracion where Nombre='{0}'", pAdministrador), _conn);
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
                }
                _conn.Close();
            }
            return ListaAdministracion;
        }

        public int EliminarAdministrador(Int64 pIdAdministrador)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("delete from Administrador where Id = {0}", pIdAdministrador)
                , _conn);
            int resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }

        public static int ModificarAdministrador(Administrador pAdministrador)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                string _Sql = "UPDATE Administracion SET Nombres=@Nombres,Apellidos=@Apellidos,Dui=@Dui," +
                    "Email=@Email,Telefono=@Telefono,NomUsu=@NomUsu,Pass=@Pass WHERE IdAdministrador=@IdAdministrador";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@Id", pAdministrador.IdAdmin);
                comando.Parameters.AddWithValue("@Nombre", pAdministrador.Nombres);
                comando.Parameters.AddWithValue("@Apellido", pAdministrador.Apellidos);
                comando.Parameters.AddWithValue("@Dui", pAdministrador.Dui);
                comando.Parameters.AddWithValue("@Email", pAdministrador.Email);
                comando.Parameters.AddWithValue("@Telefono", pAdministrador.Telefono);
                comando.Parameters.AddWithValue("@NomUsu", pAdministrador.NomUsu);
                comando.Parameters.AddWithValue("@Pass", pAdministrador.Pass);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }
        }
    }
}
