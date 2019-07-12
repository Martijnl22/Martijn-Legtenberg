using System;

namespace _01.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Voer een nummer in : ");
             int decimalNumber = int.Parse(Console.ReadLine());
            int getal = decimalNumber;

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binair:  {0}", result);
            //Console.Write("Geef een getal in ");

            int rest = getal;
            string hexValue = "";
            while (rest > 0)
            {
                getal = rest % 16;
                hexValue = hexValue + "" + getal.ToString(); // Nog omzetten naar hex waarde;

                rest = rest / 16;

            }
            if (getal == 10)
            {
                hexValue = hexValue + "A";
            }
            else if (getal == 11)
            {
                hexValue = hexValue + "B";
            }
            else if (getal == 12)
            {
                hexValue = hexValue + "C";
            }
            else if (getal == 13)
            {
                hexValue = hexValue + "D";
            }
            else if (getal == 14)
            {
                hexValue = hexValue + "E";
            }
            else if (getal == 15)
            {
                hexValue = hexValue + "F";
            }
            Console.WriteLine("hexwaarde: " + hexValue);

            Console.ReadKey();
        }
    }
}