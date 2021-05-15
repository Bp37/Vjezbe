using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2
{
    class Static_Instanca
    {
        public static bool Prost (int broj)
        {
            bool prost = true;
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            return prost;
        }

        public bool Savrsen(int broj)
        {
            int ZbrojDjeljitelja = 0;
            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    ZbrojDjeljitelja += i;
                }
            }
            if (broj == ZbrojDjeljitelja)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
