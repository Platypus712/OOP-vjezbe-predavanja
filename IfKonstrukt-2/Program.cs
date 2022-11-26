using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfKonstrukt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvi_broj;
            int drugi_broj;
            Console.WriteLine("Unesite prvi broj: ");
            int.TryParse(Console.ReadLine(), out prvi_broj);
            Console.WriteLine("Unesite drugi broj: ");
            int.TryParse(Console.ReadLine(), out drugi_broj);

            if (prvi_broj > drugi_broj)
            {
                Console.WriteLine("Broj {0} je veći!", prvi_broj);
            }

            if (prvi_broj < drugi_broj)
            {
                Console.WriteLine("Broj {0} je manji!", prvi_broj);
            }

            Console.ReadKey();
        }
    }
}