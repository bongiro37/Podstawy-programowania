using System;


namespace Petla_for_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            posiadający n wierszy i k kolumn. Użyj pętli for.
            */

            int a, b, n, k;
            Console.Write("Podaj liczbe n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe k: ");
            k = Convert.ToInt32(Console.ReadLine());

            for(a=1;a<=n;a++)
            {
                for(b = 1; b <= k; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
