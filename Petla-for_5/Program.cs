using System;

namespace Petla_for_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Wczytaj liczbę naturalną n(n> 1). Narysuj na ekranie z gwiazdek trójkąt prostokątny.Użyj
            pętli for
            */

            int a, b, n;
            Console.Write("Podaj liczbe n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (a = 1; a <= n; a++)
            {
                for(b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
