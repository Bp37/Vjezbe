using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 1 broj: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Unesite 2 broj: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj: {0}", Static.Zbroj(a, b));

            Console.WriteLine("Unesite broj za kubiranje: ");
            double broj = double.Parse(Console.ReadLine());
            Console.WriteLine(Static.Kub(broj));
            Console.Write("Unesite x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Unesite y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite y2:");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Udaljenost tocaka: {0}", Static.Udaljenost(x1, x2, y1, y2));
            Console.Write("Unesi celzijuse: ");
            Console.WriteLine("Fahrenheit: ", Static.Fahrenheit(broj));
            Console.ReadLine();
        }
    }
}
