using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime, prezime;

            Console.WriteLine("Unesite svoje ime: ");
            ime = Console.ReadLine();
            
            Console.WriteLine("Unesite svoje prezime: ");
            prezime = Console.ReadLine();

            Console.WriteLine("Bok, {0} {1}!", ime, prezime);

            int uneseniZnak;

            Console.WriteLine("\nUnesite jedan znak: ");
            uneseniZnak = Console.Read();

            Console.WriteLine(uneseniZnak);
            Console.WriteLine((char)uneseniZnak);

            Console.ReadKey();
        }
    }
}
