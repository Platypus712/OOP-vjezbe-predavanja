using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> imena = new HashSet<string>();
            imena.Add("Pero");
            imena.Add("Nikola");
            imena.Add("je");
            imena.Add("super");

            foreach (string ime in imena)
            {
                Console.WriteLine(ime);
            }

            Console.ReadKey();
        }
    }
}
