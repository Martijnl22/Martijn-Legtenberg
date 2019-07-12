using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Eindcijfer = 0;
            Console.WriteLine("Geef uw eerste cijfer");
            double Cijfer1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef uw tweede cijfer");
            double Cijfer2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef uw derde cijfer");
            double Cijfer3 = Convert.ToDouble(Console.ReadLine());

            Eindcijfer = (Cijfer1 + Cijfer2 + Cijfer3) / 3;
            if (Eindcijfer < 6)
            {
                Console.WriteLine("u heeft een F gehaald, uw cijfer is " + Eindcijfer);
                Console.ReadLine();
            }
            else if (Eindcijfer >= 9)
            {
                Console.WriteLine("u heeft een A gehaald, uw cijfer is " + Eindcijfer);
                Console.ReadLine();
            }
            else if (Eindcijfer >= 8)
            {
                Console.WriteLine("u heeft een B gehaald, uw cijfer is " + Eindcijfer);
                Console.ReadLine();
            }
            else if (Eindcijfer >= 7)
            {
                Console.WriteLine("u heeft een C gehaald, uw cijfer is " + Eindcijfer);
                Console.ReadLine();
            }
            else if (Eindcijfer >= 6)
            {
                Console.WriteLine("u heeft een D gehaald, uw cijfer is " + Eindcijfer);
                Console.ReadLine();
            }
            else if (Eindcijfer < 6)
            {
                Console.WriteLine("u heeft een F gehaald, uw cijfer is " + Eindcijfer);
                Console.ReadLine();
            }
        }
    }
}