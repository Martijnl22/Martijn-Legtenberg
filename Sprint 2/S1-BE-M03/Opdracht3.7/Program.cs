using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw tekst in...");
            string invoer = Convert.ToString(Console.ReadLine());

            invoer = invoer.Replace("a", "*");
            invoer = invoer.Replace("i", "*");
            invoer = invoer.Replace("e", "*");
            invoer = invoer.Replace("u", "*");
            invoer = invoer.Replace("o", "*");

            Console.Write(invoer);
            Console.ReadLine();
        }
    }
}