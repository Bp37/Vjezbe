using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    class Program
    {
        static double[] ReadNumbersFromFile(string fileName)
        {
            List<double> numbers = new List<double>();
            using (StreamReader file = File.OpenText(fileName))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        numbers.Add(double.Parse(line));
                    }
                }
            }
            return numbers.ToArray();

        }
    }
}
