using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdacht5._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer het temperatuur in: ");
            int temperatuur = Convert.ToInt32( Console.ReadLine());

            for (int i = -30 ; i <= 50; i++) 
            {
                if((temperatuur >= -30 && temperatuur < -20) && (i >= -30 && i < -20))
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    
                    Console.Write(" ");
                }

                if ((temperatuur >= -19 && temperatuur < -10) && (i >= -19 && i < -10))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");
                }

                if ((temperatuur >= -9 && temperatuur < 0) && (i >= -9 && i < 0))
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Write(" ");
                }

                if ((temperatuur >= 1 && temperatuur < 10) && (i >= 1 && i < 10))
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" ");
                }
                if ((temperatuur >= 11 && temperatuur < 20) && (i >= 11 && i < 20))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(" ");
                }

                if ((temperatuur >= 21 && temperatuur < 30) && (i >= 21 && i < 30))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }

                if ((temperatuur >= 31 && temperatuur < 50) && (i >= 31 && i < 50))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write(" ");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");


                }

   


            }
            Console.ReadLine();
            
        }
    }
}

