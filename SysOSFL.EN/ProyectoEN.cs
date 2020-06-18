using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOSFL.EN
{



    public class ProyectosEN
    {
        public Int64 IdProyecto { get; set; }
        public string Codigo_pro { get; set; }
        public string NombreProyecto { get; set; }
        public string TipoProyecto { get; set; }
        public string ProgresoProyecto { get; set; }
        public string PresupuestoProyecto { get; set; }
        public Int32 JefeProyecto { get; set; }
        public ProyectosEN() { }

        public ProyectosEN(Int64 pIdProyecto, string pCodigo, string pNombreProyecto, string pTipoProyecto, string pProgresoProyecto, string pPresupuestoProyecto, int pJefeProyecto)
        {
            IdProyecto = pIdProyecto;
            Codigo_pro = pCodigo;
            NombreProyecto = pNombreProyecto;
            TipoProyecto = pTipoProyecto;
            ProgresoProyecto = pProgresoProyecto;
            PresupuestoProyecto = pPresupuestoProyecto;
            JefeProyecto = pJefeProyecto;
        }
    }
}