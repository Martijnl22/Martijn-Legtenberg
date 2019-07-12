using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //INVOER
            Console.WriteLine("Wat is uw voornaam?");
            string voornaam = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Wat is uw tussenvoegsel?");
            string tussenvoegsel = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Wat is uw achternaam?");
            string achternaam = Convert.ToString(Console.ReadLine());

            //GENERATOR
            int tekens = voornaam.Length + tussenvoegsel.Length + achternaam.Length;

            //UITVOER
            Console.WriteLine("Uw usernaam is : ");
            Console.WriteLine(voornaam.Substring(0, 1) + achternaam + tekens);

            Console.ReadKey();
        }
    }
}