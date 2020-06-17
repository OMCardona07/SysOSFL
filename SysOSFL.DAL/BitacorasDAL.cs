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
    public class BitacorasDAL
    {

        public int AgregarBitacora(BitacorasEN pProyecto)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("insert into Bitacora(Codigo_Pro, Codigo_bi,Descripcion_bi,Fecha_bi) Values('{0}','{1}','{2}','{3}')", pProyecto.CodigoProyecto, pProyecto.CodigoBi, pProyecto.Descripcion, pProyecto.Fecha)
               , _conn);
            int resultado = comando.ExecuteNonQuery();

            _conn.Close();
            return resultado;


        }
        public int EliminarBitacora(BitacorasEN pProyecto)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("delete from Bitacora where Codigo_bi = '{0}'", pProyecto.CodigoBi)
                , _conn);

            int resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }
        public List<BitacorasEN> BuscarBitacora(BitacorasEN pProyecto)
        {
            List<BitacorasEN> _listaProyectosEN = new List<BitacorasEN>();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos(String.Format("select * from Bitacora where Codigo_Pro = '{0}'", pProyecto.CodigoProyecto), _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    BitacorasEN obj = new BitacorasEN();

                    obj.CodigoProyecto = reader.GetString(0);
                    obj.CodigoBi = reader.GetString(1);
                    obj.Descripcion = reader.GetString(2);
                    obj.Fecha = reader.GetString(3);


                    _listaProyectosEN.Add(obj);



                }
                _conn.Close();
                return _listaProyectosEN;
            }
        }












        public int ModificarBitacora(BitacorasEN pProyecto)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                string _Sql = "UPDATE Bitacora SET Codigo_Pro=@Codigo_Pro,Codigo_bi=@Codigo_bi,Descripcion_bi=@Descripcion_bi,Fecha_bi=@Fecha_bi WHERE Codigo_bi=@Codigo_bi";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@Codigo_Pro", pProyecto.CodigoProyecto);
                comando.Parameters.AddWithValue("@Codigo_bi", pProyecto.CodigoBi);
                comando.Parameters.AddWithValue("@Descripcion_bi", pProyecto.Descripcion);
                comando.Parameters.AddWithValue("@Fecha_bi", pProyecto.Fecha);



                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }
        }

    }
}
