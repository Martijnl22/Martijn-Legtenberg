using System;

namespace Opdracht2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string LerenBekleding2;
            string Automaat2;
            string MetalicLak2;
            double Metaliclak = 0;
            double LerenBekleding = 0;
            double automaat = 0;
            double Totaal;
            double BTW = 21;
            string datum = DateTime.Now.ToLongDateString();

            //INFO BEDRIJF\\
            Console.WriteLine("Welkom bij autobedrijf De Zon");
            Console.WriteLine("De zon in uw ogen!");
            Console.ReadLine();

            Console.WriteLine("Een moment geduld AUB er zijn enkele wachtende voor u...");
            Console.ReadLine();

            Console.WriteLine("U wordt geholpen door Koen de Groot!");
            Console.WriteLine();

            //INVUL GEDEELTE KLANT\\

            Console.WriteLine("Wat is uw naam?");
            string Naam = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Geef de prijs in van uw standaard auto!");
            double standaardprijs = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Wilt u Metalic lak toevoegen aan uw auto? [+5%] Ja / Nee");
            MetalicLak2 = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Wilt u leren bekleding in uw auto? [+5%] Ja / Nee");
            LerenBekleding2 = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Wilt u een handgeschakelde auto of een Automaat? [+1000] Automaat / Handgeschakelde");
            Automaat2 = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("Uw keuzes worden verwerkt, een moment geduld AUB...");
            Console.ReadLine();

            //REKEN GEDEELTE\\
            if (MetalicLak2 == "Ja")
            {
                Metaliclak = standaardprijs * 0.5;
                Console.WriteLine("Metalic lak toegevoegd! " + Metaliclak);
            }
            else
            {
                Console.WriteLine("Geen Metalic lak toegevoegd!");
            }

            if (LerenBekleding2 == "Ja")
            {
                LerenBekleding = standaardprijs - standaardprijs * 0.5;
                Console.WriteLine("Leren bekleding toegevoegd! " + LerenBekleding);
            }
            else
            {
                Console.WriteLine("Geen leren bekleding toegevoegd!");
            }

            if (Automaat2 == "Automaat")
            {
                automaat = standaardprijs - standaardprijs + 1000;
                Console.WriteLine("Automaat is toegevoegd!");
            }
            else
            {
                Console.WriteLine("Automaat niet toegevoegd!");
            }

            //FACTUUR GEDEELTE\\
            BTW = standaardprijs * 0.21;
            Console.WriteLine(" ");
            Console.WriteLine("Berekening wordt gestart...");
            Console.WriteLine(" ");
            Console.WriteLine("De BTW voor deze order bedraagd: " + BTW);

            Totaal = standaardprijs + BTW + automaat + LerenBekleding + Metaliclak;
            Console.WriteLine(Naam + "! het totaal bedrag van de auto is : " + Totaal);
            Console.WriteLine("");

            //OVERIGE INFORMATIE\\
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("- Overige informatie bestelling");
            Console.WriteLine("- Order nummer : 35945125");
            Console.WriteLine("- Track & Trace : 3SHENM3090686");
            Console.WriteLine("- Verwachtte levertijd : 10 Werkdagen");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.ReadLine();
        }
    }
}
