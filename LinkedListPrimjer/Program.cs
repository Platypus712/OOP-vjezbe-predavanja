using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> brojevi = new LinkedList<int>();
            brojevi.AddLast(3);
            brojevi.AddLast(100);
            brojevi.AddLast(4);
            brojevi.AddLast(5);

            for (int i = 0; i < brojevi.Count; i++)
            {
                Console.WriteLine(brojevi.ElementAt(i));
            }

            Console.ReadKey();
        }
    }
}
