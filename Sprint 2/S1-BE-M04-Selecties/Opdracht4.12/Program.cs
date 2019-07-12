using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Opdracht4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Now = DateTime.Now;
            int dayOfYear = DateTime.Now.DayOfYear;

            Console.WriteLine("Vandaag");
            Console.ReadLine();

            Console.WriteLine("Vandaag is het het jaar " + DateTime.Now.Year);
            Console.ReadLine();

            Console.WriteLine("Vandaag valt in de maand " + DateTime.Now.ToString("MMMM"));
            Console.ReadLine();

            Console.WriteLine("Vandaag is het " + DateTime.Now.DayOfWeek);
            Console.ReadLine();

            Console.WriteLine("Het is vandaag de " + DateTime.Now.Day + "e dag van de maand");
            Console.ReadLine();

            Console.WriteLine("Het is vandaag de " + DateTime.Now.DayOfYear + "e van het jaar " + DateTime.Now.Year);
            Console.ReadLine();

            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            Console.WriteLine("Het week nummer is: {1} ", Now, cal.GetWeekOfYear(Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek));
            Console.ReadLine();
        }
    }
}