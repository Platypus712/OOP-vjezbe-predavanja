using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            string poruka = "Ovo je moja poruka!";
            Console.WriteLine("poruka = {0}", poruka);
            Console.WriteLine("duljina poruke = {0}", poruka.Length);
            
            for (int i = 0; i < poruka.Length; i++)
            {
                Console.WriteLine("znak na indeksu {0} = {1}", i, poruka[i]);
            }

            Console.ReadKey();
        }
    }
}
