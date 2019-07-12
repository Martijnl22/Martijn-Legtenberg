using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double oppervlakte, prijs, kortingtwee, kortingdrie;

            //INVOER
            Console.WriteLine("Camper stallen");
            Console.ReadLine();

            //Console.WriteLine("Hoeveel vierkante meter wilt u huren? (1.50,- M2)");
            //Double Vierkantmeter = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Hoelang wilt u een contract? (Bij minimaal 2Jaar 5% Korting - Bij minimaal 3Jaar 10% korting)");
            //Double Contract = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hoe breedt is uw Camper?");
            Double Breedte = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hoe lang is uw Camper?");
            Double Lengte = Convert.ToDouble(Console.ReadLine());

            //BEREKENING
            oppervlakte = Breedte * Lengte;
            prijs = oppervlakte * 1.50;
            kortingtwee = prijs - prijs * 0.05;
            kortingdrie = prijs - prijs * 0.1;

            Console.WriteLine("De kosten voor een een jarig huurcontract zijn: " + prijs);
            Console.WriteLine("De kosten voor een twee jarig huurcontract zijn: " + kortingtwee);
            Console.WriteLine("De kosten voor een drie jarig huurcontract zijn: " + kortingdrie);
            Console.ReadKey();
        }
    }
}
