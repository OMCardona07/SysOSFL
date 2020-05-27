using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOSFL.EN
{
    public class Administrador
    {
        public Int64 IdAdmin { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dui { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string NomUsu { get; set; }
        public string Pass { get; set; }


        public Administrador() { }

        public Administrador(Int64 pIdAdmin, string pNombres, string pApellidos, string pDui, string pEmail,
            string pTelefono, string pNomUsu, string pPass)
        {
            IdAdmin = pIdAdmin;
            Nombres = pNombres;
            Apellidos = pApellidos;
            Dui = pDui;
            Email = pEmail;
            Telefono = pTelefono;
            NomUsu = pNomUsu;
            Pass = pPass;
        }
    }
}
