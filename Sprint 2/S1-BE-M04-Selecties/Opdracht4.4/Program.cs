using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double rest = 0;

            Console.WriteLine("Voer een eerste getal in!");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Voer een tweede getal in!");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            rest = (getal1 % getal2);
            if (rest == 0)
            {
                Console.WriteLine("Het getal is een veelvoud!");
            }
            else
            {
                Console.WriteLine("Het getal is geen veelvoud!");
            }
            Console.ReadKey();
        }
    }
}
