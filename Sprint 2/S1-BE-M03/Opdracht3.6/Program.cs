using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double gemiddeldeNED, gemiddeldeENG, gemiddeldeWIS, gemiddeldePRG, gemiddeldeDBD, gemiddeldeALG;


            Console.WriteLine("CijferLijst");
            Console.ReadLine();

            Console.WriteLine("Wat is je studenten nummer? : ");
            double studentnummer = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je voornaam + achternaam? : ");
            string naam = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Wat is je eerst behaalde cijfer voor het vak: NED ? : ");
            double NED1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je tweede behaalde cijfer voor het vak : NED ? : ");
            double NED2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je eerste behaalde cijfer voor het vak : ENG ? : ");
            double ENG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je tweede behaalde cijfer voor het vak : ENG ? : ");
            double ENG2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je eerst behaalde cijfer voor het vak : WIS ? : ");
            double WIS1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je tweede behaalde cijfer voor het vak : WIS ? : ");
            double WIS2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je eerste behaalde cijfer voor het vak : PRG ? : ");
            double PRG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je tweede behaalde cijfer voor het vak : PRG ? : ");
            double PRG2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je eerst behaalde cijfer voor het vak : DBD ? : ");
            double DBD1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je tweede behaalde cijfer voor het vak : DBD ? : ");
            double DBD2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je tweede behaalde cijfer voor het vak : ALG ? : ");
            double ALG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je tweede behaalde cijfer voor het vak : ALG ? : ");
            double ALG2 = Convert.ToDouble(Console.ReadLine());


            //BEREKENING
            gemiddeldeNED = (NED1 + NED2) / 2;
            gemiddeldeENG = (ENG1 + ENG2) / 2;
            gemiddeldeWIS = (WIS1 + WIS2) / 2;
            gemiddeldePRG = (PRG1 + PRG2 + PRG2) / 3;
            gemiddeldeDBD = (DBD1 + DBD2 + DBD2) / 3;
            gemiddeldeALG = (ALG1 + ALG2 + ALG2) / 3;
        }
    }
}
