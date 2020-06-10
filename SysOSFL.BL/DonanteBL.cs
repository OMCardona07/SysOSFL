using SysOSFL.DAL;
using SysOSFL.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOSFL.BL
{
    public class DonanteBL
    {
        DonanteDAL DAL = new DonanteDAL();
        public int AgregarDonante(Donante pDonante)
        {
            return DAL.AgregarDonante(pDonante);
        }

        public int ModificarDonante(Donante pDonante)
        {
            return DonanteDAL.ModificarDonante(pDonante);
        }

        public int EliminarDonante(Int64 pId)
        {
            return DAL.EliminarDonante(pId);
        }

        public List<Donante> ObtenerTodosDonantes()
        {
            return DAL.ObtenerDonantes();
        }


        public Donante ObtenerDonantePorId(Int64 pId)
        {
            return DAL.ObtenerDonantesPorId(pId);
        }
    }
}
