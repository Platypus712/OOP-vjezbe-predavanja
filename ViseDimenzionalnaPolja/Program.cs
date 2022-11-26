using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViseDimenzionalnaPolja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] podaci = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            int i = 0;
            int j = 0;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", podaci[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
