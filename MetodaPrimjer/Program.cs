using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;
            int rezultat;

            try
            {
                Console.WriteLine("Unesi prvi broj: ");
                prviBroj = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesi drugi broj: ");
                drugiBroj = int.Parse(Console.ReadLine());
                rezultat = podijeli(prviBroj, drugiBroj);
                Console.WriteLine("Rezultat: {0}", rezultat);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("Zabranjeno je dijeljenje s nulom");
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Pogrešan unos!");
                Console.WriteLine(ex2.Message);
            }
            catch (Exception ex3)
            {
                Console.WriteLine("Pogreška!");
                Console.WriteLine(ex3.Message);
            }
        }

        private static int podijeli(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
}
