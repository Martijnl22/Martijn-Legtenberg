using System;
using System.Diagnostics;

namespace Opdracht_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            string naam;
            int leeftijd;

            timer.Start();

            Console.WriteLine("Wat is uw naam?");
            naam = Console.ReadLine();
            Console.WriteLine("Wat is uw leeftijd?");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            timer.Stop();

            var seconden = timer.ElapsedMilliseconds / 1000;
            Console.WriteLine("Je deed er: " + seconden + " seconden over!");
            Console.ReadKey();
        }
    }
}