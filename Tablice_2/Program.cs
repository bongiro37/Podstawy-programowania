using System;

namespace Tablice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący wczytane
            liczby w odwrotnej kolejności na ekranie
            */

            int[] tablica = new int[1000];
            int a, n;
            Console.Write("Podaj ilość elementów w tablicy: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (a = 0; a < n; a++)
            {
                Console.Write("Podaj {0} element tablicy: ", a);
                tablica[a] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Wczytane liczby w odwrotnej kolejności: ");
            for (a = n - 1; a >= 0; a--)
            {
                Console.Write("{0} ", tablica[a]);
            }
            Console.ReadKey(true);
        }
    }
}
