using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
            }

            Console.ReadKey();
        }
    }
}