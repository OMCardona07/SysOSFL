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
    public class DonacionesDAL
    {
        public int AgregarDonacion(Donaciones pDonacion)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("INSERT INTO Donaciones(IdDonante,Id_pro,Monto,Estado)  Values('{0}','{1}','{2}','{3}')", pDonacion.IdDonante, pDonacion.IdProyecto, pDonacion.Monto, pDonacion.Estado), _conn);
            int resultado = comando.ExecuteNonQuery();

            _conn.Close();
            return resultado;
        }

        public static int ModificarDonacion(Donaciones pDonacion)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                string _Sql = "UPDATE Donaciones SET IdDonante=@IdDonante,Id_pro=@Id_pro,Monto=@Monto," +
                    " Estado=@Estado WHERE IdDonacion=@IdDonacion";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@IdDonacion", pDonacion.IdDonacion);
                comando.Parameters.AddWithValue("@IdDonante", pDonacion.IdDonante);
                comando.Parameters.AddWithValue("@Id_pro", pDonacion.IdProyecto);
                comando.Parameters.AddWithValue("@Monto", pDonacion.Monto);
                comando.Parameters.AddWithValue("@Estado", pDonacion.Estado);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }


        }

        public int EliminarDonacion(Int64 pIdDonacion)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("DELETE FROM Donaciones WHERE IdDonacion = {0}", pIdDonacion)
                , _conn);
            int resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }
    }
}
