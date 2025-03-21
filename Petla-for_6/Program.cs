using System;


namespace Petla_for_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Wczytaj liczbę naturalną n(n> 1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
            nie jest trójkątem prostokątnym.Użyj pętli for.
            */

            int a, b, n;
            Console.Write("Podaj liczbe n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(a=1;a<=n;a++)
            {
                for (b = 1; b <= n - a; b++)
                    Console.Write(" ");
                for (b = 1; b <= 2 * a - 1; b++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
