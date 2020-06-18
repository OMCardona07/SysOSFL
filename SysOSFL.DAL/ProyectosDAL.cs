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
    public class ProyectosDAL
    {
        public int AgregarProyecto(ProyectosEN pProyecto)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("insert into Proyecto(Codigo_pro,Nombre,Tipo_pro,Presupuesto,idJefe,Progreso_pro) Values('{0}','{1}','{2}','{3}','{4}','{5}')", pProyecto.Codigo_pro, pProyecto.NombreProyecto, pProyecto.TipoProyecto, pProyecto.PresupuestoProyecto, pProyecto.JefeProyecto, pProyecto.ProgresoProyecto)
               , _conn);
            int resultado = comando.ExecuteNonQuery();

            _conn.Close();
            return resultado;


        }
        public int Eliminarproyecto(Int64 IdPro)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("delete from Proyecto where IdProyecto = '{0}'", IdPro)
                , _conn);

            int resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return resultado;
        }
        public List<ProyectosEN> BuscarProyectos(ProyectosEN pProyecto)
        {
            List<ProyectosEN> _listaProyectosEN = new List<ProyectosEN>();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos(String.Format("select * from Proyecto where Codigo_Pro = '{0}'", pProyecto.IdProyecto), _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    ProyectosEN obj = new ProyectosEN();

                    obj.NombreProyecto = reader.GetString(0);
                    obj.TipoProyecto = reader.GetString(1);
                    obj.IdProyecto = Convert.ToInt64(reader.GetString(2));
                    obj.ProgresoProyecto = reader.GetString(3);
                    obj.PresupuestoProyecto = reader.GetString(4);
                    obj.JefeProyecto = reader.GetInt32(5);
                    _listaProyectosEN.Add(obj);



                }
                _conn.Close();
                return _listaProyectosEN;
            }
        }

        public List<ProyectosEN> ObtenerProyectos()
        {
            List<ProyectosEN> _listaProyectosEN = new List<ProyectosEN>();
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                IDbCommand commando = BDComun.ObtenerComandos("select * from Proyecto", _conn);
                IDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    ProyectosEN obj = new ProyectosEN();

                    obj.NombreProyecto = reader.GetString(0);
                    obj.TipoProyecto = reader.GetString(1);
                    obj.IdProyecto = Convert.ToInt64(reader.GetString(2));
                    obj.ProgresoProyecto = reader.GetString(3);
                    obj.PresupuestoProyecto = reader.GetString(4);
                    obj.JefeProyecto = reader.GetInt32(5);


                    _listaProyectosEN.Add(obj);



                }
                _conn.Close();
                return _listaProyectosEN;
            }
        }



        public int ModificarProyecto(ProyectosEN pProyecto)
        {
            using (IDbConnection conn = BDComun.ObtenerConexion())
            {
                conn.Open();
                string _Sql = "UPDATE Proyecto SET Codigo_pro=@Codigo_pro,Nombre=@Nombre,Tipo_pro=@Tipo_pro,Presupuesto=@Presupuesto," +
                    " idJefe=@idJefe,Progreso_pro=@Progreso_pro WHERE IdProyecto=@IdProyecto";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@IdProyecto", pProyecto.IdProyecto);
                comando.Parameters.AddWithValue("@Codigo_pro", pProyecto.Codigo_pro);
                comando.Parameters.AddWithValue("@Nombre", pProyecto.NombreProyecto);
                comando.Parameters.AddWithValue("@Tipo_pro", pProyecto.TipoProyecto);
                comando.Parameters.AddWithValue("@Presupuesto", pProyecto.PresupuestoProyecto);
                comando.Parameters.AddWithValue("@idJefe", pProyecto.JefeProyecto);
                comando.Parameters.AddWithValue("@Progreso_pro", pProyecto.ProgresoProyecto);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }
        }
    }
}
