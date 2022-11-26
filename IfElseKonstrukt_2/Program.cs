using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseKonstrukt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesite broj: ");
            int.TryParse(Console.ReadLine(), out broj);

            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj {0} je paran broj!", broj);
            }
            else
            {
                Console.WriteLine("Broj {0} je neparan broj!", broj);
            }

            Console.ReadKey();
        }
    }
}