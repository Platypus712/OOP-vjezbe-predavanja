using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] podaci = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Unesite broj: ");
                int unos = int.Parse(Console.ReadLine());
                podaci[i] = unos;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} ", podaci[i]);
            }

            Console.WriteLine("\nPetlja foreach");
            int zbroj = 0;
            foreach (var broj in podaci)
            {
                Console.WriteLine(broj);
                zbroj += broj; //zbroj = zbroj + broj
            }
            Console.WriteLine("\nZbroj unesenih brojeva iznosi {0}", zbroj);

            Console.ReadKey();
        }
    }
}
