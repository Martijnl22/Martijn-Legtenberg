using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer het aantal punten in van het vak Wiskunde");
            double wiskunde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer het aantal punten in van het vak Scheikunde");
            double scheikunde = Convert.ToDouble(Console.ReadLine());

            if (wiskunde < 40 && scheikunde < 40)
            {
                Console.Write("U mag niet deelnemen aan het examen!");
            }
            if (wiskunde > 59 && scheikunde > 59)
            {
                Console.Write("U mag deelnemen aan het examen!");
            }
            if (wiskunde + scheikunde > 179)
                Console.WriteLine("U mag deelnemen aan het examen!");
            Console.ReadKey();
        }
    }
}
