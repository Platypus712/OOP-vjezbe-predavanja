using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileKonstrukt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int zbroj = 0;
            int broj = 0;

            do
            {
                Console.WriteLine("Unesite {0}. cijeli broj", broj);
                int.TryParse(Console.ReadLine(), out broj);
                zbroj += broj;
                i++;
            }

            while (i < 10);

            Console.ReadKey();
        }
    }
}