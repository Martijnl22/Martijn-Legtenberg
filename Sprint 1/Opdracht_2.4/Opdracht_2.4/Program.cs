using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.Write("Wat is uw volledige naam?: ");
            string firstname = Convert.ToString(Console.ReadLine());

            Console.Write("Wanneer bent u jarig?");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());

            int antwoord = now.Year - birthday.Year;
            Console.Write(firstname + " is: " + antwoord);
            Console.ReadKey();
        }
    }
}