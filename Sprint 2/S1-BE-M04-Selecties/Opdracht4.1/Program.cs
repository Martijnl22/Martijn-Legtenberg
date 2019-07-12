using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Voer een getal in");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            if (getal1 > getal2)
            {
                Console.WriteLine("Het eerste getal is het grootst");
                Console.ReadKey();
            }
            if (getal1 < getal2)
            {
                Console.WriteLine("Het tweede getal is het grootst");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("De getallen zijn gelijk aan elkaar");
                Console.ReadKey();
            }
        }
    }
}

