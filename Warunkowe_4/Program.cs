using System;

namespace Warunkowe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            największej z tych liczb.
            */

            double a, b, c, d, e, min, max;
            Console.Write("Podaj pierwszą liczbę: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj czwartą liczbę: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj piątą liczbę: ");
            e = Convert.ToDouble(Console.ReadLine());

            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza", min);

            max = a;
            if (b>max) max = b;
            if (c>max) max = c;
            if (d>max) max = d;
            if (e>max) max = e;
            Console.WriteLine("Liczba {0} jest największa", max);
            Console.ReadKey(true);
        }
    }
}
