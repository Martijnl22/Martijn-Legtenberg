using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._10
{
    class


        Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een oneven getal in tussen 10 en 100.");
            double getal = Convert.ToDouble(Console.ReadLine());
            int number = Convert.ToInt32(getal);

            //Berekening even of oneven

            int som = 0;

            if ((getal % 2) == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Oneven");


                //Loop

                for (int i = 1; i < number; i++)
                    if (i % 2 != 0)


                    {
                        Console.WriteLine(i + "%" + i + "=" + i);
                    }
            }

            Console.ReadKey();


            Console.WriteLine("De som van " + getal.ToString() + "met alle andere getalen is " + number.ToString() + ".");
            Console.ReadLine();

        }
    }
}