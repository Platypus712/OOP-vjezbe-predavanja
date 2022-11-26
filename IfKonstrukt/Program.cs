using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfKonstrukt
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesite neki broj: ");
            int.TryParse(Console.ReadLine(), out broj);

            if (broj > 0)
            {
                Console.WriteLine("Broj {0} je pozitivan broj", broj);
            }

            if (broj < 0)
            {
                Console.WriteLine("Broj {0} je negativan broj", broj);
            }

            if (broj == 0)
            {
                Console.WriteLine("Broj {0} je jednak nuli", broj);
            }

            Console.ReadKey();
        }
    }
}