using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOSFL.EN
{
    public class BitacorasEN
    {

        public string CodigoProyecto { get; set; }
        public string CodigoBi { get; set; }
        public string Descripcion { get; set; }

        public String Fecha { get; set; }


        public BitacorasEN() { }


        public BitacorasEN(String pCodigoProyecto, string pCodigoBi, string pDescripcion, string pFecha)
        {
            CodigoProyecto = pCodigoProyecto;
            CodigoBi = pCodigoBi;
            Descripcion = pDescripcion;
            Fecha = pFecha;




        }



    }
}
