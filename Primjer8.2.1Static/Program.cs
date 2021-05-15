using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer8._2._1Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // private konstruktor
            // zabranjuje instanciranje klase helper
            // Helper h = new Helper();

            double rez = Helper.Zbroj(100, 500);
            Console.WriteLine(rez);

            double kub = Helper.Kub(2);
            Console.WriteLine(kub);

            // primjer math klase s static metodama
            Math.PI;

            Console.ReadKey();
        }
    }
}
