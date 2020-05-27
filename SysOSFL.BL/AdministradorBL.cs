using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOSFL.EN;
using SysOSFL.DAL;

namespace SysOSFL.BL
{
    public class AdministradorBL
    {
        AdministradorDAL DAL = new AdministradorDAL();
        public int AgregarAdministrador(Administrador pAdmin)
        {
            return DAL.AgregarAdmin(pAdmin);
        }
    }
}
