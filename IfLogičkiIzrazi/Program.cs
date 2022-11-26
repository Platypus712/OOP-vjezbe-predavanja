using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfLogickiIzrazi
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesite broj: ");
            int.TryParse(Console.ReadLine(), out broj);

            if (broj > 0 && broj < 10)
            {
                Console.WriteLine("Unijeli ste pozitivan jednoznamenkasti broj");
            }

            Console.ReadKey();
        }
    }
}