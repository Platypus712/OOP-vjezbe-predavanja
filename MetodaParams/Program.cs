using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj1;
            int zbroj2;
            int zbroj3;

            zbroj1 = izracunaj(2, 7);
            Console.WriteLine("Prvi zbroj: {0}", zbroj1);
            
            zbroj2 = izracunaj(4, 1, -2, 10);
            Console.WriteLine("Drugi zbroj: {0}", zbroj2);
            
            zbroj3 = izracunaj();
            Console.WriteLine("Treci zbroj: {0}", zbroj3);

        }

        private static int izracunaj(params int[] brojevi)
        {
            int zbroj = 0;
            foreach (int broj in brojevi)
            {
                zbroj += broj;
            }

            return zbroj;
        }
    }
}
