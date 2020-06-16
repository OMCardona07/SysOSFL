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
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("insert into Proyecto(Codigo_pro,Nombre,Tipo_pro,Presupuesto,Progreso_pro) Values('{0}','{1}','{2}','{3}','{4}')", pProyecto.Codigo_pro, pProyecto.NombreProyecto, pProyecto.TipoProyecto, pProyecto.PresupuestoProyecto, pProyecto.ProgresoProyecto, pProyecto.JefeProyecto)
               , _conn);
            int resultado = comando.ExecuteNonQuery();

            _conn.Close();
            return resultado;


        }
        public int Eliminarproyecto(ProyectosEN pProyecto)
        {
            IDbConnection _conn = BDComun.ObtenerConexion();
            _conn.Open();
            IDbCommand comando = BDComun.ObtenerComandos(string.Format("delete from Proyecto where Codigo_Pro = '{0}'", pProyecto.IdProyecto)
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
                    obj.JefeProyecto = reader.GetString(5);
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
                    obj.JefeProyecto = reader.GetString(5);


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
                string _Sql = "UPDATE Proyecto SET Nombre_Pro=@Nombre_Pro,Tipo_Pro=@Tipo_Pro,Codigo_Pro=@Codigo_Pro,Progreso_Pro=@Progreso_Pro,Presupuesto_Pro=@Presupuesto_Pro,Jefe_Pro=@Jefe_Pro WHERE Codigo_Pro=@Codigo_Pro";

                SqlCommand comando = new SqlCommand(_Sql, conn as SqlConnection);
                comando.Parameters.AddWithValue("@Nombre_Pro", pProyecto.NombreProyecto);
                comando.Parameters.AddWithValue("@Tipo_Pro", pProyecto.TipoProyecto);
                comando.Parameters.AddWithValue("@Codigo_Pro", pProyecto.IdProyecto);
                comando.Parameters.AddWithValue("@Progreso_Pro", pProyecto.ProgresoProyecto);
                comando.Parameters.AddWithValue("@Presupuesto_Pro", pProyecto.PresupuestoProyecto);
                comando.Parameters.AddWithValue("@Jefe_Pro", pProyecto.JefeProyecto);
                int resultado = comando.ExecuteNonQuery();
                conn.Close();
                return resultado;
            }
        }
    }
}
