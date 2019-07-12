using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel werkuren heeft uw draaibank dit jaar gemaakt?");
            double Draaiuren = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hoe oud is de draaibank die u gebruikt?");
            double Leeftijddraaibank = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hoeveel storingen heeft de draaibank per jaar?");
            double Draaibankstoringen = Convert.ToDouble(Console.ReadLine());

            if (Draaiuren > 9999)
                {
                Console.Write("");
            }
            if (Leeftijddraaibank > 7)
            {
                Console.Write("");
            }
            if (Draaibankstoringen > 25)
            {
                Console.Write("U moet de draaibank vervangen!");
            }
            else
            {
                Console.Write("De draaibank hoeft niet vervangen te worden!");
            }
            Console.ReadKey();

        }
    }
}
