using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ElseIf_Else
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
                Console.WriteLine("Unijeli ste negativan broj");
            }
            else if (broj > 0)
            {
                Console.WriteLine("Unijeli ste pozitivan broj");
            }
            else
            {
                Console.WriteLine("Unijeli ste nulu");
            }

            Console.ReadKey();
        }
    }
}