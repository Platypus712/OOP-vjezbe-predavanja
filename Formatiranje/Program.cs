using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = "Pero";
            int godine = 18;
            string grad = "Zagreb";

            Console.WriteLine("{0} ima {1} godina i živi u {2}u.", ime, godine, grad);

            //Poravnanje
            Console.WriteLine("\n123456");
            Console.WriteLine("{0,6}", 123); //3 mjesta prazno + 3 mjesta od predane vrijednosti
            Console.WriteLine("{0,6}", 1234);
            Console.WriteLine("{0,6}", 12);
            Console.WriteLine("{0,-6}", 123);

            //Format standardnog ispisa
            Console.WriteLine("\n{0:C2}", 123.456);
            Console.WriteLine("{0:D6}", -1234);
            Console.WriteLine("{0:E2}", 123);
            Console.WriteLine("{0:F2}", -123.456);
            Console.WriteLine("{0:N2}", 1234567.8);
            Console.WriteLine("{0:P}", 0.456);
            Console.WriteLine("{0:X}", 254);

            //Format korisničkog ispisa
            Console.WriteLine("\n{0:0.00}", 1);
            Console.WriteLine("{0:#.##}", 0.234);
            Console.WriteLine("{0:#####}", 12345.67);
            Console.WriteLine("{0:(0#) ### ## ##}", 13334455);
            Console.WriteLine("{0:##%}", 0.234);

            //Format standardnog ispisa datuma
            DateTime mojPodatak = new DateTime(2022, 11, 15, 10, 49, 50); //godina-mjesec-dan-sat-minuta-sekunde

            Console.WriteLine("\n{0:d}", mojPodatak);
            Console.WriteLine("{0:D}", mojPodatak);
            Console.WriteLine("{0:t}", mojPodatak);
            Console.WriteLine("{0:T}", mojPodatak);
            Console.WriteLine("{0:Y}", mojPodatak);

            //Format korisničkog ispisa datuma
            Console.WriteLine("\n{0:dd.MM.yyyy HH:mm:ss}", mojPodatak);
            Console.WriteLine("{0:d.MM.yy}", mojPodatak);

            //Format ispisa podatka s popisa
            Console.WriteLine("\n{0:G}", DayOfWeek.Tuesday);
            Console.WriteLine("{0:D}", DayOfWeek.Tuesday);
            Console.WriteLine("{0:X}", DayOfWeek.Tuesday);

            Console.ReadKey();
        }
    }
}
