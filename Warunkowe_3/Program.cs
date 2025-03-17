using System;

namespace Warunkowe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            największej z tych liczb.
            */

            double a, b, c;
            Console.Write("Podaj pierwszą liczbę: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a <= b) && (a <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", a);
            else if ((b >= a) && (a >= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", b);
            else
                Console.WriteLine("Liczba {0} jest najmniejsza", c);

            if ((a>=b) && (a >= c))
                Console.WriteLine("Liczba {0} jest największa", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("Liczba {0} jest największa", b);
            else
                Console.WriteLine("Liczba {0} jest największa", c);
            Console.ReadKey(true);
        }
    }
}
