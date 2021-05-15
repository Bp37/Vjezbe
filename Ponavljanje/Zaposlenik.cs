using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje
{
    class Zaposlenik
    {
        private string _ime;

        public string Ime
        {
            get
            {
                return _ime;
            }
            set
            {
                _ime = value;
            }
        }

        private string _prezime;

        public string Prezime 
        {
            get { return _prezime; } 
            set { _prezime = value; }
        }

        // ukoliko ne navedemo modifikator pristupa
        // implicitno se dodjeljuje private
        string _jmbg;

        public string JMBG 
        { 
            get { return _jmbg; }
            set { _jmbg = value; }
        }

        private double _brojBodova;

        public double BrojBodova 
        { 
            get { return _brojBodova; }
            set 
            {
                if(value > 0)
                {
                    _brojBodova = value;
                }
                else
                {
                    throw new Exception("Možete unijeti samo pozitivnu vrijednost!");
                }
            }
        }

        private double _vrijednostBoda;

        public double VrijednostBoda
        {
            get { return _vrijednostBoda; }
            set 
            {
                if(value > 0)
                {
                    _vrijednostBoda = value;
                }
                else
                {                    
                    Exception ex = new Exception("Možete unijeti samo pozitivnu vrijednost!");
                    throw ex;
                }
            }
        }

        public double Porez
        {
            get
            {
                double neto = NetoIzracunPlace(); // ovjde će doći metoda

                if(neto < 3000)
                {
                    return neto * 0.06;
                }
                else if(neto < 6000)
                {
                    return neto * 0.12;
                }
                else
                {
                    return neto * 0.2;
                }
            }
        }

        public double NetoIzracunPlace()
        {
            return BrojBodova * VrijednostBoda;
        }

        public double BrutoIzracunPlace()
        {
            return NetoIzracunPlace() + Porez;
        }

        public Zaposlenik()
        {

        }

        public Zaposlenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public Zaposlenik(string ime, string prezime, string jmbg)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jmbg;
        }
    }
}
