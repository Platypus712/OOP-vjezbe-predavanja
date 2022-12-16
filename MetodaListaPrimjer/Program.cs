using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaListaPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = popuniListu();
            ispisi(lista);
        }

        private static List<string> popuniListu()
        {
            List<string> lista = new List<string>();
            lista.Add("Pero");
            lista.Add("Marko");
            lista.Add("Jura");
            lista.Add("Ana");
            lista.Add("Ivana");

            return lista;
        }

        private static void ispisi(List<string> imena)
        {
            foreach (string ime in imena)
            {
                Console.WriteLine(ime);
            }
        }
    }
}
