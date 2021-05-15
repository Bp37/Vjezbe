using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DOSEG VARIJABLI
            int i = 0;
            
            for(i = 0; i < 10; i++)
            {     
                // LOKALNI DOSEG
                Console.WriteLine(i);
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }
            int mojBroj = 70;
            //int mojBroj = 70;
            MojBroj();
            
            //j = 50;
            i = 99;

            // j = 50;

            Osoba o = new Osoba();
            o._prezime = "Moja osoba";
            o.DajIme();

            Console.ReadKey();
        }

        static void MojBroj()
        {
            // lokalna varijabla potprograma MojBroj
            // nije vidljiva izvana
            int mojBroj = 5;
            Console.WriteLine(mojBroj);
        }

        static void MojDrugiBroj()
        {
            // kompajler baca grešku jer 
            // ovaj doseg ne "vidi" doseg Main metode
            mojBroj
        }
    }
}
