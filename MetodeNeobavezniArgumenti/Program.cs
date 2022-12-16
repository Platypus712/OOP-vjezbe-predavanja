using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeNeobavezniArgumenti
{
    class Program
    {
        static void Main(string[] args)
        {
            ispisi(1, 2, 3);
            ispisi(1);
            ispisi(1, z: 3);
            ispisi(z: 3, x:1);
        }

        private static void ispisi(int x, int y = 1, int z = 5)
        {
            Console.WriteLine("{0} {1} {2}", x, y, z);
        }
    }
}
