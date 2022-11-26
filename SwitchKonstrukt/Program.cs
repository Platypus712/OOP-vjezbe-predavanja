using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchKonstrukt
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesite neki broj: ");
            int.TryParse(Console.ReadLine(), out broj);

            switch (broj)
            {
                case 1:
                    Console.WriteLine("Unijeli ste jedinicu");
                    break;
                case 2:
                    Console.WriteLine("Unijeli ste dvojku");
                    break;
                case 3:
                    Console.WriteLine("Unijeli ste trojku");
                    break;
                default:
                    Console.WriteLine("Unijeli ste neki drugi broj");
                    break;
            }

            Console.ReadKey();
        }
    }
}