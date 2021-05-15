using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer8._2._1Static
{
    class Helper
    {
        private Helper()
        {

        }

        public static double Zbroj(double brojJedan, double broj2)
        {
            return brojJedan + broj2;
        }

        public static double Kub(double broj)
        {
            return broj * broj * broj;
        }
    }
}
