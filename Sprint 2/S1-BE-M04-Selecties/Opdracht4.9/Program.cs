using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in van een maand");
            double getal = Convert.ToDouble(Console.ReadLine());

            if (getal == 1)
            {
                Console.Write("De maand is Januari!");
            }
            if (getal == 2)
            {
                Console.Write("De maand is Februari!");
            }
            if (getal == 3)
            {
                Console.Write("De maand is Maart!");
            }
            if (getal == 4)
            {
                Console.Write("De maand is April!");
            }
            if (getal == 5)
            {
                Console.Write("De maand is Mei!");
            }
            if (getal == 6)
            {
                Console.Write("De maand is Juni!");
            }
            if (getal == 7)
            {
                Console.Write("De maand is Juli!");
            }
            if (getal == 8)
            {
                Console.Write("De maand is Augustus!");
            }
            if (getal == 9)
            {
                Console.Write("De maand is September!");
            }
            if (getal == 10)
            {
                Console.Write("De maand is Oktober!");
            }
            if (getal == 11)
            {
                Console.Write("De maand is November!");
            }
            if (getal == 12)
            {
                Console.Write("De maand is December!");
            }
            Console.ReadKey();
        }
    }
}
