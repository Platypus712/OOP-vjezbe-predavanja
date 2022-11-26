using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PromjenaRegPostavki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime mojPodatak = new DateTime(2022, 11, 15, 11, 6, 50);

            //Promjena regionalnih postavki na SAD
            Console.WriteLine("Regionalne postavke za SAD");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:D}", mojPodatak);
            Console.WriteLine("{0:C2}", 1234.56);
            
            //Promjena regionalnih postavki na HR
            Console.WriteLine("\nRegionalne postavke za HR");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("hr-HR");
            Console.WriteLine("{0:D}", mojPodatak);
            Console.WriteLine("{0:C2}", 1234.56);

            Console.ReadKey();
        }
    }
}
