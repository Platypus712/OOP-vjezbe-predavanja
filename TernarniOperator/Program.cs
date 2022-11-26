using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernarniOPperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            string rezultat;

            Console.WriteLine("Unesite broj: ");
            int.TryParse(Console.ReadLine(), out broj);

            rezultat = broj % 2 == 0 ? "paran" : "neparan";
            Console.WriteLine("Broj {0} je {1} broj", broj, rezultat);

            Console.ReadKey();
        }
    }
}