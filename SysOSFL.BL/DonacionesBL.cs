using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOSFL.EN;
using SysOSFL.DAL;

namespace SysOSFL.BL
{
    public class DonacionesBL
    {
        DonacionesDAL DAL = new DonacionesDAL();
        public int AgregarDonacion(Donaciones pDonacion)
        {
            return DAL.AgregarDonacion(pDonacion);
        }

        public int ModificarDonacion(Donaciones pDonacion)
        {
            return DonacionesDAL.ModificarDonacion(pDonacion);
        }
        public int ModificarDonacion_d(Donaciones pDonacion)
        {
            return DonacionesDAL.ModificarDonacion_d(pDonacion);
        }

        public int EliminarDonacion(Int64 pId)
        {
            return DAL.EliminarDonacion(pId);
        }
    }
}
