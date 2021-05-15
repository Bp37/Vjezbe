using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancirati klasu Zaposlenik
            Zaposlenik zap = new Zaposlenik("Mirko", "Prezime", "132456789");

            // upravljanje pogreškama
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                try
                {
                    // unijeti broj bodova
                    Console.WriteLine("Unesite broj bodova:");
                    zap.BrojBodova = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch(FormatException ex)
                {
                    // Specifična greška
                    Console.WriteLine("Greška " + ex.Message);
                    Console.WriteLine("Hmm nešto si krivo unio!");
                }
                catch(ArgumentNullException ex)
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška " + ex.Message);
                }
            }

            provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                try
                {                 
                    // unijeti vrijednost boda
                    Console.WriteLine("Unesite vrijednost boda:");
                    zap.VrijednostBoda = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška " + ex.Message);
                }
            }

            // na kraju ispisati Ime i Prezime Zaposlenika
            Console.WriteLine("Ime i prezime: " + zap.Ime + " " + zap.Prezime);
            Console.WriteLine($"{zap.NetoIzracunPlace()}");
            // Neto plaću
            // Porez
            Console.WriteLine("Porez {0}", zap.Porez);
            // Bruto plaća
            Console.WriteLine("Bruto {0}", zap.BrutoIzracunPlace());


            Console.ReadKey();
        }
    }
}
