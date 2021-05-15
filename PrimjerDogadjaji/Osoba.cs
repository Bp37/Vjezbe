using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerDogadjaji
{
    class Osoba
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
            get
            {
                return _prezime;
            }
            set
            {
                if(!string.IsNullOrEmpty(_prezime) && value != _prezime)
                {
                    if(PromijenjoPrezime != null)
                    {
                        PromijenjoPrezime(_prezime, value);
                    }
                }


                _prezime = value;
            }
        }

        public delegate void NaPromjenuPrezimenaDelegat(string staroPrezime, string novo);
        public event NaPromjenuPrezimenaDelegat PromijenjoPrezime;
    }
}
