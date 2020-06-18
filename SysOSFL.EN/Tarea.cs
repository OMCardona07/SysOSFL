using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOSFL.EN
{
    public class Tarea
    {
        public Int64 IdTarea { get; set; }
        public Int32 Id_pro { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fecha_ini { get; set; }
        public string Fecha_fin { get; set; }
        public string Estado { get; set; }


        public Tarea() { }

        public Tarea(Int64 pIdTarea, Int32 pId_pro, string pNombre, string pDescripcion, string pFechaIni,
            string pFechaFin, string pEstado)
        {
            IdTarea = pIdTarea;
            Id_pro = pId_pro;
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Fecha_ini = pFechaIni;
            Fecha_fin = pFechaFin;
            Estado = pEstado;
        }
    }
}
