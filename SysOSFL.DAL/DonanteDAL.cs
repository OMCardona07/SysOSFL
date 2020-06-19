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
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("INSERT INTO Donante(NombreEm,N_Emp,Email," +
                "Telefono,NomUsu,Pass,Credencial)" +
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
                string _Sql = "UPDATE Donante SET NombreEm=@NombreEm,N_Emp=@N_Emp,Email=@Email," +
                    " Telefono=@Telefono,NomUsu=@NomUsu,Pass=@Pass,Credencial=@Credencial WHERE IdDonante=@IdDonante";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@IdDonante", pDonante.IdDonante);
                comando.Parameters.AddWithValue("@NombreEm", pDonante.NombreEm);
                comando.Parameters.AddWithValue("@N_Emp", pDonante.Nrc);
                comando.Parameters.AddWithValue("@Email", pDonante.Email);
                comando.Parameters.AddWithValue("@Telefono", pDonante.Telefono);
                comando.Parameters.AddWithValue("@NomUsu", pDonante.NomUsu);
                comando.Parameters.AddWithValue("@Pass", pDonante.Pass);
                comando.Parameters.AddWithValue("@Credencial", pDonante.Credencial);
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

        public static int BuscarDonante(string pNomUsu, string pPass)
        {
            //List<Usuario> _Lista = new List<Usuario>();
            int resultado;
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("BuscarDonante", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@NomUsu", pNomUsu));
                _comando.Parameters.Add(new SqlParameter("@Pass", pPass));
                SqlDataReader _reader = _comando.ExecuteReader();

                if (_reader.Read())
                {
                    resultado = 1;
                }
                else
                {
                    resultado = 0;
                }
                _conn.Close();
            }
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
