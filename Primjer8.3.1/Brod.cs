using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer8._3._1
{
    class Brod : Vozilo
    {
        public delegate void NaPromjenuistisnineDelegat(object o, EventArgs e);
        public event NaPromjenuistisnineDelegat NaPromjenuIstisnine;
        private double _istisnina;
        public double Istisnina
        {
            get { return _istisnina; }

            set
            {
                _istisnina = value;
                if (NaPromjenuIstisnine != null)
                {
                    NaPromjenuIstisnine(this, new EventArgs());
                }
            }
        }
    }
}
