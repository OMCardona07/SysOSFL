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
        public int AgregarAdmin(Administrador pAdmin)
        {
            return DAL.AgregarAdmin(pAdmin);
        }

        public int ModificarAdministracion(Administrador pAdminin)
        {
            return AdministradorDAL.ModificarAdministrador(pAdminin);
        }

        public int EliminarAdministracion(Int64 pId)
        {
            return DAL.EliminarAdministrador(pId);
        }

        public List<Administrador> ObtenerTodosAdministracion()
        {
            return DAL.ObtenerAdministradores();
        }
        

        public Administrador ObtenerAdministracionporId(Int64 pId)
        {
            return DAL.ObtenerAdministracionporId(pId);
        }

        public List<Administrador> ObtenerAdministracionporNombre(string pAdministracion)
        {
            return DAL.ObtenerAdministracionporNombre(pAdministracion);
        }
    }
}
