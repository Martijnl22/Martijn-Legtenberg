using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Antwoord;

            Console.Write("Wat is de lengte van uw Kubus?: ");
            Double lengte = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wat is de hoogte van uw Kubus?: ");
            Double hoogte = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wat is de breedte van uw Kubus?: ");
            Double breedte = Convert.ToDouble(Console.ReadLine());

            Antwoord = lengte * hoogte * breedte;
            Console.WriteLine("De inhoud van de kubus is : " + Antwoord);
            Console.ReadKey();
        }
    }
}