using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer3
{
    class Osoba  : System.Object
    {
        private string _ime;

        public string Ime 
        {
            get { return _ime; }
            set { _ime = value; }
        }

        private string _prezime;

        public string Prezime 
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public Osoba(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public string DajPunoIme()
        {
            // isto kao i kad formatiramo tekst kod Console.WriteLine("{0} {1}", ...)
            // return this.Ime + " " + this.Prezime;
            return string.Format("{0} {1}", this.Ime, this.Prezime);
        }

        // Premošćivanje metode (Override)
        // Premostiti možemo samo metode koje su označene
        // sa abstract ili virtual
        public override string ToString()
        {
            return this.DajPunoIme();
        }
    }
}
