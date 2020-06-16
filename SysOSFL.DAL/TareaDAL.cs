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
    public class TareaDAL
    {
        public int AgregarTarea(Tarea pTarea)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("INSERT INTO Bitacora(Id_pro,Nombre,Descripcion," +
                "Fecha_ini,Fecha_fin,Estado)" +
                " Values('{0}','{1}','{2}','{3}','{4}','{5}')",
                pTarea.Id_pro, pTarea.Nombre, pTarea.Descripcion, pTarea.Fecha_ini, pTarea.Fecha_fin, pTarea.Estado), _conn);
            int resultado = comando.ExecuteNonQuery();

            _conn.Close();
            return resultado;
        }

        public static int ModificarTarea(Tarea pTarea)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                string _Sql = "UPDATE Bitacora SET Id_pro=@Id_pro,Nombre=@Nombre,Descripcion=@Descripcion,Fecha_ini=@Fecha_ini," +
                    " Fecha_fin=@Fecha_fin,Estado=@Estado WHERE IdBitacora=@IdBitacora";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@IdBitacora", pTarea.IdTarea);
                comando.Parameters.AddWithValue("@Id_pro", pTarea.Id_pro);
                comando.Parameters.AddWithValue("@Nombre", pTarea.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", pTarea.Descripcion);
                comando.Parameters.AddWithValue("@Fecha_ini", pTarea.Fecha_ini);
                comando.Parameters.AddWithValue("@Fecha_fin", pTarea.Fecha_fin);
                comando.Parameters.AddWithValue("@Estado", pTarea.Estado);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }
        }

        public int EliminarTarea(Int64 pIdTarea)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("DELETE FROM Bitacora WHERE Id = {0}", pIdTarea)
                , _conn);
            int resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }
    }
}
