using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Johan Martijn Legtenberg");
            Console.ResetColor();
            Console.WriteLine("1e Esweg 12");
            Console.WriteLine("7642BK Wierden");
            Console.WriteLine("22 Jaar");
            Console.ReadLine();
        }
    }
}