using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOSFL.EN;
using SysOSFL.DAL;

namespace SysOSFL.BL
{
    public class BitacorasBL
    {
        BitacorasDAL DAL = new BitacorasDAL();
        public int AgregarBi(BitacorasEN pProyecto)
        {
            return DAL.AgregarBitacora(pProyecto);
        }

        public int eliminarBi(BitacorasEN pProyecto)
        {
            return DAL.EliminarBitacora(pProyecto);
        }

        public int ModificarBi(BitacorasEN pProyecto)
        {

            return DAL.ModificarBitacora(pProyecto);

        }


        public List<BitacorasEN> buscarBi(BitacorasEN pProyecto)
        {

            return DAL.BuscarBitacora(pProyecto);

        }




    }
}
