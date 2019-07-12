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
            const int een = 1;
            const int twee = 2;
            const int drie = 3;
            const int vier = 4;

            int getal;

            Console.WriteLine("Vul een van de volgende getallen in: 1 2 3 4");
            getal = Convert.ToInt16(Console.ReadLine());

            if (getal == een)
                Console.WriteLine("Klaveren");
            else if (getal == twee)
                Console.WriteLine("Ruiten");
            else if (getal == drie)
                Console.WriteLine("Harten");
            else if (getal == vier)
                Console.WriteLine("Schoppen");

            else Console.WriteLine(" Geen geldige waarde ingevoerd!");

            Console.ReadKey();
        }
    }
}
