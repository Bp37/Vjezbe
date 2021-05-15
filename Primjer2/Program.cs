using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 50;
            // šaljem vrijednost
            // kopiram vrijednost
            Uvecaj(broj);
            Console.WriteLine(broj);
            // šaljem memorijsku lokaciju
            UvecajPoRef(ref broj);
            Console.WriteLine(broj);

            int drugiBroj;
            string nekiBroj = Console.ReadLine();

            bool uspjeh = int.TryParse(nekiBroj, out drugiBroj);

            if (uspjeh)
            {
                Console.WriteLine("Uspješno parsiranje!");
            }

            Console.WriteLine(uspjeh);


            Console.ReadKey();
        }

        static void Uvecaj(int broj)
        {
            broj++;
        }

        static void UvecajPoRef(ref int broj)
        {
            broj++;
        }


    }
}
