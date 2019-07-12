using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Wat is de geboortedatum van de man?: ");
            DateTime man = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Wat is de geboortedatum van de vrouw?: ");
            DateTime vrouw = Convert.ToDateTime(Console.ReadLine());

            bool condition = false;

            if (man < vrouw) 
            {
                double antwoord = (vrouw - man).TotalDays;
                Console.WriteLine("Man ouder");
                Console.Write("De man is " + antwoord + " dagen ouder dan de vrouw.");
                Console.ReadKey();
            }
            else
            {
                double antwoord = (man - vrouw).TotalDays;
                Console.WriteLine("Vrouw ouder");
                Console.Write("De vrouw is " + antwoord + " dagen ouder dan de man.");
                Console.ReadKey();
            }
        }
    }
}