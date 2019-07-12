using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in!");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer een tweede getal in!");
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoe wilt u de ingevoerde getallen berekenen? 1 = Optellen 2 = Aftrekken 3 = Verminigvuldigen 4 = Delen 5 = Modulus");
            double invoer = Convert.ToDouble(Console.ReadLine());

            double plus = getal1 + getal2;
            double min = getal1 - getal2;
            double keer = getal1 * getal2;
            double delen = getal1 / getal2;
            double modulus = getal1 % getal2;

            if ( invoer == 1 )
            {
                Console.WriteLine("Het antwoord is " + plus);
            }
            if (invoer == 2)
            {
                Console.WriteLine("Het antwoord is " + min);
            }
            if (invoer == 3)
            {
                Console.WriteLine("Het antwoord is " + keer);
            }
            if (invoer == 4)
            {
                Console.WriteLine("Het antwoord is " + delen);
                if (getal2 == 0)
                {
                    Console.WriteLine("Delen door nul is flauwekul.");
                }
            }
            if (invoer == 5)
            {
                Console.WriteLine("Het antwoord is " + modulus);
                if (invoer == 0)
                    Console.WriteLine("Delen door nul is flauwekul.");
            }
            Console.ReadKey();
        }
    }
}
