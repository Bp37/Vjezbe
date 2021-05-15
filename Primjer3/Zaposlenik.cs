using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer3
{
    class Zaposlenik : Osoba
    {
        public string SifraZaposlenika { get; set; }

        public Zaposlenik(string ime, string prezime)
            : base(ime, prezime)
        {
            string dajime = base.Ime;
            base.DajPunoIme();
        }


        // Skrivanje (hide) metode
        // Kompajler javlja upozorenje
        public new string DajPunoIme()
        {
            return string.Format("{0} {1}", base.Ime, base.Prezime);

        }
    }
}
