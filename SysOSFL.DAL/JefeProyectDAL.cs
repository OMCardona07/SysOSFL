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
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("INSERT INTO JefeProyect(Nombres_J,Apellidos_J,Dui_J," +
                "Email_J,Telefono_J,NomUsu_J,Pass_J,Credencial_J)" +
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
                string _Sql = "UPDATE JefeProyect SET Nombres_J=@Nombres_J,Apellidos_J=@Apellidos_J,Dui_J=@Dui_J,Email_J=@Email_J," +
                    " Telefono_J=@Telefono_J,NomUsu_J=@NomUsu_J,Pass_J=@Pass_J,Credencial_J=@Credencial_J WHERE IdJefe=@IdJefe";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@IdJefe", pJefe.IdJefeProyect);
                comando.Parameters.AddWithValue("@Nombres_J", pJefe.Nombres);
                comando.Parameters.AddWithValue("@Apellidos_J", pJefe.Apellidos);
                comando.Parameters.AddWithValue("@Dui_J", pJefe.Dui);
                comando.Parameters.AddWithValue("@Email_J", pJefe.Email);
                comando.Parameters.AddWithValue("@Telefono_J", pJefe.Telefono);
                comando.Parameters.AddWithValue("@NomUsu_J", pJefe.NomUsu);
                comando.Parameters.AddWithValue("@Pass_J", pJefe.Pass);
                comando.Parameters.AddWithValue("@Credencial_J", pJefe.Credencial);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }


        }

        public int EliminarJefeProyect(Int64 pIdJefeProyect)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("DELETE FROM JefeProyect WHERE IdJefe = {0}", pIdJefeProyect)
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
                IDbCommand commando = BDComun.ObtenerComandos(string.Format("select * from JefeProyect where IdJefe={0}", _listaJefes), _conn);
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
