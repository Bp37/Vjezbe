using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer8._3._1
{
    class Vozilo
    {
        private string _naziv;
        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        private string _boja;
        public string Boja
        {
            get { return _boja; }
            set { _boja = value; }
        }

        private int _ks;
        public int KS
        {
            get { return _ks; }
            set { _ks = value; }
        }

        public double KStoKW()
        {
            return (double)KS * 0.736;
        }
    }
}

