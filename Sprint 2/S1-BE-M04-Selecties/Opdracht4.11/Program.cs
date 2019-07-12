using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in van een maand");
            double getal = Convert.ToDouble(Console.ReadLine());

            if (getal == 1)
            {
                Console.Write("De maand is Januari, Deze maand bevat 31dagen");
            }
            if (getal == 2)
            {
                Console.Write("De maand is Februari, Deze maand bevat 28dagen, In een schrikkeljaar is het aantal dagen in februari 29");
            }
            if (getal == 3)
            {
                Console.Write("De maand is Maart, Deze maand bevat 31dagen");
            }
            if (getal == 4)
            {
                Console.Write("De maand is April, Deze maand bevat 30dagen");
            }
            if (getal == 5)
            {
                Console.Write("De maand is Mei, Deze maand bevat 31dagen");
            }
            if (getal == 6)
            {
                Console.Write("De maand is Juni, Deze maand bevat 30dagen");
            }
            if (getal == 7)
            {
                Console.Write("De maand is Juli, Deze maand bevat 31dagen");
            }
            if (getal == 8)
            {
                Console.Write("De maand is Augustus, Deze maand bevat 31dagen");
            }
            if (getal == 9)
            {
                Console.Write("De maand is September, Deze maand bevat 30dagen");
            }
            if (getal == 10)
            {
                Console.Write("De maand is Oktober, Deze maand bevat 31dagen");
            }
            if (getal == 11)
            {
                Console.Write("De maand is November, Deze maand bevat 30dagen ");
            }
            if (getal == 12)
            {
                Console.Write("De maand is December, Deze maand bevat 31dagen ");
            }
            Console.ReadKey();
        }
    }
}
