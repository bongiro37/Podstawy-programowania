using System;
using System.Threading;


namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            iloraz.
            */

            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("{0}+{1}={2}", a, b, suma);
            Console.WriteLine("{0}-{1}={2}", a, b, roznica);
            Console.WriteLine("{0}*{1}={2}", a, b, iloczyn);
            Console.WriteLine("{0}/{1}={2}", a, b, iloraz); //dzielac przez 0 wyrzuci blad

            Console.ReadKey(true);

        }
    }
}
