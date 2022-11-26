using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesite broj: ");
            int.TryParse(Console.ReadLine(), out broj);

            if (broj < 0)
            {
                Console.WriteLine("Broj {0} je negativan", broj);
            }
            else
            {
                if (broj > 0)
                {
                    Console.WriteLine("Broj {0} je pozitivan", broj);
                }
                else
                {
                    Console.WriteLine("Unijeli ste nulu");
                }
            }

            Console.ReadKey();
        }
    }
}