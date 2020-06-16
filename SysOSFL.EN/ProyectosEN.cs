using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOSFL.EN
{



    public class ProyectosEN
    {

        public string NombreProyecto { get; set; }

        public string TipoProyecto { get; set; }

        public String IdProyecto { get; set; }
        public string ProgresoProyecto { get; set; }
        public string PresupuestoProyecto { get; set; }
        public string JefeProyecto { get; set; }
        public ProyectosEN() { }

        public ProyectosEN(String pIdProyecto, string pNombreProyecto, string pTipoProyecto, string pProgresoProyecto, string pPresupuestoProyecto, string pJefeProyecto)
        {
            IdProyecto = pIdProyecto;
            NombreProyecto = pNombreProyecto;
            TipoProyecto = pTipoProyecto;
            ProgresoProyecto = pProgresoProyecto;
            PresupuestoProyecto = pPresupuestoProyecto;
            JefeProyecto = pJefeProyecto;
        }
    }
}