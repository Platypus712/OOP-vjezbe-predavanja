using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileKonstrukt
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            int zbroj = 0;
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Unesite cijeli broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                zbroj += broj;

                i++;
            }

            Console.WriteLine("Zbroj iznosi {0}", zbroj);

            Console.ReadKey();
        }
    }
}