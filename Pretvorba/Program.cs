using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretvorba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mojBrojKaoString;
            int a;

            Console.WriteLine("Unesi jedan broj: ");
            mojBrojKaoString = Console.ReadLine();
            a = int.Parse(mojBrojKaoString);
            Console.WriteLine(mojBrojKaoString);

            string mojBrojKaoTekst;
            int broj;
            bool uspjesnaKonverzija;

            Console.WriteLine("\nUnesi jedan broj: ");
            mojBrojKaoTekst = Console.ReadLine();
            uspjesnaKonverzija = int.TryParse(mojBrojKaoTekst, out broj);
            Console.WriteLine("Uspješna konverzija: {0}", uspjesnaKonverzija);
            Console.WriteLine("Vrijednost nakon konverzije: {0}", broj);

            Console.ReadKey();
        }
    }
}
