using System;

namespace Opdracht2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //INVOER GETAL 1
            Console.WriteLine("Calculator 3000");
            Console.ReadLine();
            Console.WriteLine("Getal 1");
            Console.WriteLine("Geef een getal op!");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            //INVOER GETAL 2
            Console.WriteLine("Getal 2");
            Console.WriteLine("Geef een getal op!");
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Antwoorden worden geladen, een moment geduld AUB");
            Console.WriteLine("De antwoorden zijn : ");
            Console.ReadLine();

            //BEREKEN GEDEELTE
            double Eerste_Getal_Plus_tweede_Getal = getal1 + getal2;
            double Eerste_Getal_Min_tweede_Getal = getal1 - getal2;
            double Tweede_Getal_Min_Eerste_Getal = getal2 - getal1;
            double Eerste_Getal_Maal_tweede_Getal = getal1 * getal2;
            double Eerste_Getal_Gedeeld_tweede_Getal = getal1 / getal2;
            double Tweede_Getal_Gedeeld_Eerste_Getal = getal2 / getal1;
            double Modulo_1 = getal1 % getal2;
            double Modulo_2 = getal2 % getal1;

            //ANTWOORDEN + BEREKENING
            Console.WriteLine("Eerste getal plus tweede getal = " + Eerste_Getal_Plus_tweede_Getal);
            Console.WriteLine("Eerste getal min tweede getal = " + Eerste_Getal_Min_tweede_Getal);
            Console.WriteLine("Tweede getal min eerste getal = " + Tweede_Getal_Min_Eerste_Getal);
            Console.WriteLine("Eerste getal maal tweede getal = " + Eerste_Getal_Maal_tweede_Getal);
            Console.WriteLine("Eerste getal gedeeld door tweede getal = " + Eerste_Getal_Gedeeld_tweede_Getal);
            Console.WriteLine("Tweede getal gedeeld door eerste getal = " + Tweede_Getal_Gedeeld_Eerste_Getal);
            Console.WriteLine("Restant (modulo) van eerste getal gedeeld door tweede getal = " + Modulo_1);
            Console.WriteLine("Restant (modulo) van tweede getal gedeeld door eerste getal = " + Modulo_2);
            Console.ReadKey();
        }
    }
}