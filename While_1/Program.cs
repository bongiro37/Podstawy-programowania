using System;

namespace While_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z
            przedziału [a,b]. Użyj pętli while.
            */

            int a, b, i;
            Console.Write("Podaj liczbę a: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i <= b)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
                i++;
            }
            Console.ReadKey(true);
        }
    }
}
