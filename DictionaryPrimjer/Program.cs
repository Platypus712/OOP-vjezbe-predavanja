using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> daniUTjednu = new Dictionary<int, string>();
            daniUTjednu.Add(1, "Ponedjeljak");
            daniUTjednu.Add(2, "Utorak");
            daniUTjednu.Add(3, "Srijedu");
            daniUTjednu.Add(4, "Četvrtak");
            daniUTjednu.Add(5, "Petak");
            daniUTjednu.Add(6, "Subotu");
            daniUTjednu.Add(7, "Nedjelju");

            int dan;
            Console.WriteLine("Unesite redni broj dana u tjednu:");
            int.TryParse(Console.ReadLine(), out dan);
            Console.WriteLine("Odabrali ste: {0}", daniUTjednu[dan]);

            Console.ReadKey();
        }
    }
}
