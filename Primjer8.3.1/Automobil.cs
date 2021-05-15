using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer8._3._1
{
    class Automobil : Vozilo
    {
        private double _ccm;
        public double CCM
        {
            get { return _ccm; }
            set { _ccm = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} KS", base.Naziv, base.KS);
        }
    }
}
