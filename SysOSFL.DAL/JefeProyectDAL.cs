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
    public class JefeProyectDAL
    {
        public int AgregarJefe(JefeProject pJefe)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("INSERT INTO JefeProyect(Nombres,Apellidos,Dui,Email,Telefono,NomUsu,Pass,Credencial)" +
                " Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                pJefe.Nombres, pJefe.Apellidos, pJefe.Dui, pJefe.Email, pJefe.Telefono, pJefe.NomUsu, pJefe.Pass, pJefe.Credencial), _conn);
            int resultado = comando.ExecuteNonQuery();

            _conn.Close();
            return resultado;
        }

        public static int ModificarJefeProyect(JefeProject pJefe)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                string _Sql = "UPDATE JefeProyect SET Nombres=@Nombres,Apellidos=@Apellidos,Dui=@Dui,Email=@Email," +
                    " Telefono=@Telefono,NomUsu=@NomUsu,Pass=@Pass,Credencial=@Credencial WHERE IdJefeProyect=@IdJefeProyect";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@IdAdmin", pJefe.IdJefeProyect);
                comando.Parameters.AddWithValue("@Nombres", pJefe.Nombres);
                comando.Parameters.AddWithValue("@Apellidos", pJefe.Apellidos);
                comando.Parameters.AddWithValue("@Dui", pJefe.Dui);
                comando.Parameters.AddWithValue("@Email", pJefe.Email);
                comando.Parameters.AddWithValue("@Telefono", pJefe.Telefono);
                comando.Parameters.AddWithValue("@NomUsu", pJefe.NomUsu);
                comando.Parameters.AddWithValue("@Pass", pJefe.Pass);
                comando.Parameters.AddWithValue("@Credencial", pJefe.Credencial);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }


        }

        public int EliminarJefeProyect(Int64 pIdJefeProyect)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("DELETE FROM JefeProyect WHERE IdJefeProyect = {0}", pIdJefeProyect)
                , _conn);
            int resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }

        public List<JefeProject> ObtenerJefeProyect()
        {
            List<JefeProject> _listaJefes = new List<JefeProject>();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos("select * from JefeProyect", _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    JefeProject obj = new JefeProject();
                    obj.IdJefeProyect = reader.GetInt64(0);
                    obj.Nombres = reader.GetString(1);
                    obj.Apellidos = reader.GetString(2);
                    obj.Dui = reader.GetString(3);
                    obj.Email = reader.GetString(4);
                    obj.Telefono = reader.GetString(5);
                    obj.NomUsu = reader.GetString(6);
                    obj.Pass = reader.GetString(7);
                    obj.Credencial = reader.GetString(8);

                    _listaJefes.Add(obj);

                }
                _conn.Close();
                return _listaJefes;
            }
        }

        public JefeProject ObtenerJefePorId(Int64 _listaJefes)
        {
            JefeProject obj = new JefeProject();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos(string.Format("select * from JefeProyect where IdJefeProyect={0}", _listaJefes), _conn);
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
