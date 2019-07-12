using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is uw voornaam? : ");
            string voornaam = Convert.ToString(Console.ReadLine());

            Console.Write("Wat is uw tussenvoegsel? : ");
            string tussenvoegsels = Convert.ToString(Console.ReadLine());

            Console.Write("Wat is uw achternaam? : ");
            string achternaam = Convert.ToString(Console.ReadLine());

            int tekens = voornaam.Length + tussenvoegsels.Length + achternaam.Length;

            Console.Write("Uw voornaam + achternaam zijn " + tekens + " tekens lang");
            Console.ReadKey();


        }
    }
}