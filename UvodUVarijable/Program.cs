using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodUVarijable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklariranje
            string varijablaString; //primjer deklaracije varijable tipa string
            int varijablaBroj; //primjer deklaracije varijable tipa int
            double varijablaDecimalniBroj; //primjer deklaracije varijable tipa double
            bool varijablaBoolean; //primjer deklaracije varijable tipa boolean
            char varijablaChar; //primjer deklaracije varijable tipa character

            //inicijalizacija
            varijablaString = "Nina";
            varijablaBroj = 20;
            varijablaDecimalniBroj = 473.147;
            varijablaBoolean = true;
            varijablaChar = 'N';

            //ispis
            Console.WriteLine(varijablaString);
            Console.WriteLine(varijablaBroj);
            Console.WriteLine(varijablaDecimalniBroj);
            Console.WriteLine(varijablaBoolean);
            Console.WriteLine(varijablaChar);

            Console.ReadKey();
        }
    }
}
