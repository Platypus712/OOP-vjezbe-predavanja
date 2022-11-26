using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForKonstrukt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int zbroj = 0;
            int broj;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);

                zbroj += broj;
            }
            Console.WriteLine("Zbroj {0}", zbroj);

            Console.ReadKey();
        }
    }
}