using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObradaIznimki
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesite neki broj: ");

            try
            {
                //broj = int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out broj);
            }
            catch
            {
                Console.WriteLine("Dogodila se greška!");
            }
            finally
            {
                Console.WriteLine("Kraj programa!");
            }

        }
    }
}
