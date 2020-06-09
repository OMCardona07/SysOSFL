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
    public class DonanteDAL
    {
        public int AgregarDonante(Donante pDonante)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("INSERT INTO Donante(NombreEm,N_Emp,Email_E," +
                "Telefono_E,NomUsu_E,Pass_E,Credencial_E)" +
                " Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                pDonante.NombreEm, pDonante.Nrc, pDonante.Email, pDonante.Telefono, pDonante.NomUsu, pDonante.Pass, pDonante.Credencial), _conn);
            int resultado = comando.ExecuteNonQuery();

            _conn.Close();
            return resultado;
        }

        public static int ModificarDonante(Donante pDonante)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                string _Sql = "UPDATE Donante SET NombreEm=@NombreEm,N_Emp=@N_Emp,Email_E=@Email_E," +
                    " Telefono_E=@Telefono_E,NomUsu_E=@NomUsu_E,Pass_E=@Pass_E,Credencial_E=@Credencial_E WHERE IdDonante=@IdDonante";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@IdDonante", pDonante.IdDonante);
                comando.Parameters.AddWithValue("@NombreEm", pDonante.NombreEm);
                comando.Parameters.AddWithValue("@N_Emp", pDonante.Nrc);
                comando.Parameters.AddWithValue("@Email_E", pDonante.Email);
                comando.Parameters.AddWithValue("@Telefono_E", pDonante.Telefono);
                comando.Parameters.AddWithValue("@NomUsu_E", pDonante.NomUsu);
                comando.Parameters.AddWithValue("@Pass_E", pDonante.Pass);
                comando.Parameters.AddWithValue("@Credencial_E", pDonante.Credencial);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }


        }

        public int EliminarDonante(Int64 pIdDonante)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("DELETE FROM Donante WHERE IdDonante = {0}", pIdDonante)
                , _conn);
            int resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }

        public List<Donante> ObtenerDonantes()
        {
            List<Donante> _listaDonantes = new List<Donante>();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos("select * from Donante", _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    Donante obj = new Donante();
                    obj.IdDonante = reader.GetInt64(0);
                    obj.NombreEm = reader.GetString(1);
                    obj.Nrc = reader.GetString(2);
                    obj.Email = reader.GetString(3);
                    obj.Telefono = reader.GetString(4);
                    obj.NomUsu = reader.GetString(5);
                    obj.Pass = reader.GetString(6);
                    obj.Credencial = reader.GetString(7);

                    _listaDonantes.Add(obj);

                }
                _conn.Close();
                return _listaDonantes;
            }
        }

        public Donante ObtenerDonantesPorId(Int64 pIdDonante)
        {
            Donante obj = new Donante();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos(string.Format("select * from Donante where IdDonante={0}", pIdDonante), _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    ////obj.IdAdmin = reader.GetInt64(0);
                    obj.NombreEm = reader.GetString(1);
                    obj.Nrc = reader.GetString(2);
                    obj.Email = reader.GetString(3);
                    obj.Telefono = reader.GetString(4);
                    obj.NomUsu = reader.GetString(5);
                    obj.Pass = reader.GetString(6);
                    obj.Credencial = reader.GetString(7);
                }
                _conn.Close();
            }
            return obj;
        }
    }
}
