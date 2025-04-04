using System;

namespace While_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n i
            wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n). Użyj pętli while.
            */

            int n, ciag, i;
            Console.Write("Podaj liczbę n: ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 0;
            while (++i <= n)
            {
                ciag = 2 * i - 1;
                Console.WriteLine("a({0}) = {1} ", i, ciag);
            }
            Console.ReadKey(true);
        }
    }
}
