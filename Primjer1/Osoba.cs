using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer1
{
    class Osoba
    {
        // private je vidljiv samo unutar dosega klase Osoba
        private string _ime;
        public string _prezime;


        public string DajIme()
        {
            // dostupno samo unutar dosega klase
            return _ime;
        }

    }
}
