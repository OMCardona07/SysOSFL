using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOSFL.EN;
using SysOSFL.DAL;

namespace SysOSFL.BL
{
    public class ProyectosBL
    {
        ProyectosDAL DAL = new ProyectosDAL();
        

        public int AgregarPro(ProyectosEN pProyecto)
        {
            return DAL.AgregarProyecto(pProyecto);
        }

        public int eliminarPro(ProyectosEN pProyecto)
        {
            return DAL.Eliminarproyecto(pProyecto);
        }
        public List<ProyectosEN> ObtenerPro()
        {
            return DAL.ObtenerProyectos();
        }
        public int ModificarPro(ProyectosEN pProyecto)
        {

            return DAL.ModificarProyecto(pProyecto);

        }
        public List<ProyectosEN> buscarProyec(ProyectosEN pProyecto)
        {

            return DAL.BuscarProyectos(pProyecto);

        }


    }
}
