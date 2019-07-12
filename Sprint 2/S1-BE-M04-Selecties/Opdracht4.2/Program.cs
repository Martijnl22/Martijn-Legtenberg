using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Voer een getal in");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Voer een getal in");
            double getal3 = Convert.ToDouble(Console.ReadLine());

            if (getal3 < getal2)
            {
                Console.WriteLine("Het derde getal is het kleinste van de drie!");
                Console.ReadKey();
            }
            if (getal3 > getal1)
            {
                Console.WriteLine("Het derde getal is niet het kleinste van de drie!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Het derde getal is niet het kleinste van de drie!");
                Console.ReadKey();
            }
        }
    }
}

