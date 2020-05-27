using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOSFL.EN
{
    public class Donante
    {
        public Int64 IdDonante { get; set; }
        public string NombreEm { get; set; }
        public string Nrc { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string NomUsu { get; set; }
        public string Pass { get; set; }


        public Donante() { }

        public Donante(Int64 pIdDonante, string pNombreEm, string pNrc, string pEmail,
            string pTelefono, string pNomUsu, string pPass)
        {
            IdDonante = pIdDonante;
            NombreEm = pNombreEm;
            Nrc = pNrc;
            Email = pEmail;
            Telefono = pTelefono;
            NomUsu = pNomUsu;
            Pass = pPass;
        }
    }
}
