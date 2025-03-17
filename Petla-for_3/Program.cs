using System;


namespace Petla_for_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący liczbę całkowitą n(n> 2) i wypisujący na ekranie wartość sumy
            1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for
            */

            int a, b=0, n;
            Console.Write("Podaj n: ");
            n=Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= n; a++)
                b += a;
            Console.WriteLine("1+...+{0}={1}", n, b);
            Console.ReadKey(true);
        }
    }
}
