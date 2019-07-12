using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine();

            Console.Write("Geef je lengte in meter: ");
            double lengte = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geef je gewicht in kg: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            double bmi = gewicht / (lengte * lengte);

            Console.WriteLine("Je BMI is: " + bmi.ToString());

            if (bmi < 19 || bmi > 25)
            {
                Console.WriteLine("Je het een ongezond gewicht.");
            }
            else
            {
                Console.WriteLine("Je hebt een gezond gewicht.");
            }
            Console.ReadKey();

        }
    }
}