using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Mirko", "Spriko");
            
            Console.WriteLine(o.ToString());
            Console.WriteLine(o);

            Zaposlenik z = new Zaposlenik("Jura", "Klafura");
            Console.WriteLine(z);
            Console.WriteLine("Ime " + z.Ime);
            Console.WriteLine("Prezime " + z.Prezime);

            int broj = 2;
            // implicitni ToString()
            Console.WriteLine(broj);
            // eksplicitni ToString()
            Console.WriteLine(broj.ToString());

            Console.ReadKey();
        }
    }
}
