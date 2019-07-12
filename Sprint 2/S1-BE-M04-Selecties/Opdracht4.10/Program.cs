using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in");
            double getal = Convert.ToDouble(Console.ReadLine());

            if (getal == 1)
            {
                Console.Write("Vandaag is het Maandag!");
            }
            if (getal == 2)
            {
                Console.Write("Vandaag is het Dinsdag");
            }
            if (getal == 3)
            {
                Console.Write("Vandaag is het Woensdag");
            }
            if (getal == 4)
            {
                Console.Write("Vandaag is het Donderdag");
            }
            if (getal == 5)
            {
                Console.Write("Vandaag is het Vrijdag");
            }
            if (getal == 6)
            {
                Console.Write("Vandaag is het Zaterdag");
            }
            if (getal == 7)
            {
                Console.Write("Vandaag is het Zondag");
            }
            Console.ReadKey();
        }
    }
}
