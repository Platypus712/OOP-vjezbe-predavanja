using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mojaLista = new List<int>();
            mojaLista.Add(5);
            mojaLista.Add(7);
            mojaLista.Add(15);
            mojaLista.Add(20);
            mojaLista.Add(25);

            foreach  (int broj in mojaLista)
            {
                Console.WriteLine(broj);
            }

            Console.ReadKey();
        }
    }
}
