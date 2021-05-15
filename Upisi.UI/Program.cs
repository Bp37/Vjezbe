using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upisi.Model;

namespace Upisi.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // public access modifiers
            // add reference => add Upisi.Model (Projects)
            // Build!

            Polaznik p = new Polaznik();
            p.Ime = "Pero";
            p.Prezime = "Perić";

            Console.WriteLine(p.Ime + " " + p.Prezime);

            Console.ReadKey();
        }
    }
}
