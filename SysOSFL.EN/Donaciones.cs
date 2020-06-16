using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOSFL.EN
{
    public class Donaciones
    {
        public Int64 IdDonacion { get; set; }
        public Int32 IdDonante { get; set; }
        public Int32 IdProyecto { get; set; }
        public string Estado { get; set; }

        public Donaciones() { }

        public Donaciones(Int64 pIdDonacion, Int32 pIdDonante, Int32 pIdProyecto, string pEstado)
        {
            IdDonacion = pIdDonacion;
            IdDonante = pIdDonante;
            IdProyecto = pIdProyecto;
            Estado = pEstado;
        }
    }
}
