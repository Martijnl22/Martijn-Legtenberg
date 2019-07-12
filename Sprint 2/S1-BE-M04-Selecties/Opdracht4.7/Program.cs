using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Opdracht4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            String dag;
            dag = DateTime.Now.DayOfWeek.ToString();

            String hourMinute;
            hourMinute = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.ReadLine();

            Console.WriteLine(hourMinute);
            Console.ReadLine();

            DateTime date1 = DateTime.Now;

            if (dag == "Saturday" || dag == "Sunday")
            {
                if (date1.Hour >= 0 && date1.Hour <= 11)
                {
                    Console.WriteLine("Goedemorgen het is vandaag weekend");
                    Console.ReadLine();
                }
                if (date1.Hour >= 12 && date1.Hour <= 17)
                {
                    Console.WriteLine("Goedemiddag het is vandaag weekend");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Goedenavond het is vandaag weekend");
                }
            }
            else
            {
                if (date1.Hour >= 0 && date1.Hour <= 11)
                {
                    Console.WriteLine("Goedemorgen het is vandaag een werkdag");
                    Console.ReadLine();
                }
                if (date1.Hour >= 12 && date1.Hour <= 17)
                {
                    Console.WriteLine("Goedemiddag het is vandaag een werkdag");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Goedenavond het is vandaag een werkdag");
                }
            }

        }
    }
}