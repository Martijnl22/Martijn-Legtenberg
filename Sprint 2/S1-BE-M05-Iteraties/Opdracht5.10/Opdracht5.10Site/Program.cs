using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._10Site
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variablen.
            int intGetal, intTeller, intSom;
            intSom = 0;

            //Getal opvragen in de console.
            Console.Write("Geef een getal in: ");
            intGetal = Convert.ToInt16(Console.ReadLine());

            //de som van het getal met zijn voorgaande getallen weergeven in de console.
            for (intTeller = 0; intTeller < intGetal; intTeller++)
            {
                intSom = intSom + (intGetal - intTeller);

            }
            for (int i = 1; i < number; i++)
                if (i % 2 != 0)

                    Console.WriteLine(i);
            Console.WriteLine("De som van " + intGetal.ToString() + "met alle andere getalen is " + intSom.ToString() + ".");
            Console.ReadLine();
       
        }
    }
}
