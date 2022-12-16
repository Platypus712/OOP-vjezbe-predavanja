using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObradaIznimkiSpecificne
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
                Console.WriteLine("Unesite prvi broj: ");
                prviBroj = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj: ");
                drugiBroj = int.Parse(Console.ReadLine());
                rezultat = prviBroj / drugiBroj;
                Console.WriteLine("Rezultat je: {0}", rezultat);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);

            } catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            } catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message);
            }
        }
    }
}
