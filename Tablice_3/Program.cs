using System;

namespace Tablice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
            wypisujący posortowane liczby na ekranie
            */

            int[] tablica = new int[1000];
            int a, b;
            int pom, n;

            Console.Write("Podaj ilość elementów tablicy n: ");
            n=Convert.ToInt32(Console.ReadLine());
            for(a = 0; a < n; a++)
            {
                Console.Write("Podaj element tablicy: ");
                tablica[a] = Convert.ToInt32(Console.ReadLine());
            }
            for (a = 0; a < n; a++)
                for (b = a+1; b < n; b++)
                    if (tablica[a] > tablica[b])
                    {
                        pom = tablica[a];
                        tablica[a] = tablica[b];
                        tablica[b] = pom;
                    }
            Console.WriteLine("Posortowana tablica: ");
            for (a = 0; a < n; a++)
                Console.WriteLine(tablica[a]);
            Console.ReadKey(true);
        }
    }
}
