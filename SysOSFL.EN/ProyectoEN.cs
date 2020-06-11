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

        public ProyectosEN() { }

        public ProyectosEN(String pIdProyecto, string pNombreProyecto, string pTipoProyecto, string pProgresoProyecto)
        {
            IdProyecto = pIdProyecto;
            NombreProyecto = pNombreProyecto;
            TipoProyecto = pTipoProyecto;
            ProgresoProyecto = pProgresoProyecto;
        }
    }
}