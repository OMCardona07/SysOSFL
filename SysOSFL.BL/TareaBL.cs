using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOSFL.EN;
using SysOSFL.DAL;

namespace SysOSFL.BL
{
    public class TareaBL
    {
        TareaDAL DAL = new TareaDAL();
        public int AgregarTarea(Tarea pTarea)
        {
            return DAL.AgregarTarea(pTarea);
        }

        public int ModificarTarea(Tarea pTarea)
        {
            return TareaDAL.ModificarTarea(pTarea);
        }
        public int ModificarTarea_J(Tarea pTarea)
        {
            return TareaDAL.ModificarTarea_J(pTarea);
        }

        public int EliminarTarea(Int64 pId)
        {
            return DAL.EliminarTarea(pId);
        }
    }
}
