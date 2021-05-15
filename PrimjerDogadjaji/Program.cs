using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerDogadjaji
{
    class Program
    {
        static void Main(string[] args)
        {

            Osoba o = new Osoba();
            o.PromijenjoPrezime += PromijenoPrezimeHandler;
            o.Ime = "Pero";
            o.Prezime = "Perić";
            o.Prezime = "Novo prezime za Perića";

            Console.ReadKey();
        }

        static void PromijenoPrezimeHandler(string s, string n)
        {
            Console.WriteLine("OPREZ! Promijeno prezime iz {0} u {1}", s, n);
        }

    }
}
