using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOSFL.EN;
using SysOSFL.DAL;

namespace SysOSFL.BL
{
    public class JefeProyectBL
    {
        JefeProyectDAL DAL = new JefeProyectDAL();
        public int AgregarJefe(JefeProject pJefe)
        {
            return DAL.AgregarJefe(pJefe);
        }

        public int ModificarJefe(JefeProject pJefe)
        {
            return JefeProyectDAL.ModificarJefeProyect(pJefe);
        }

        public int EliminarJefe(Int64 pId)
        {
            return DAL.EliminarJefeProyect(pId);
        }

        public List<JefeProject> ObtenerTodosJefes()
        {
            return DAL.ObtenerJefeProyect();
        }
        public int BuscarJefe(string pNomUsu, string pPass)
        {
            return JefeProyectDAL.BuscarJefe(pNomUsu, pPass);
        }


        public JefeProject ObtenerJefesId(Int64 pId)
        {
            return DAL.ObtenerJefePorId(pId);
        }
    }
}
