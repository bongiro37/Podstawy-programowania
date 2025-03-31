using System;

namespace Tablice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych (dodatnich i ujemnych) i
            wypisujący wczytane liczby na ekranie.
            */

            int[] tablica;
            int a, n;

            do
            {
                Console.Write("Podaj ilość elementów w tablicy : ");
                n=Convert.ToInt32(Console.ReadLine());
            } while (n <= 0 || n > 1000);
            tablica = new int[n];
            for (a=0;a<n;a++)
            {
                Console.Write("Podaj {0} element tablicy : ", a);
                tablica[a] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Wczytane liczby : ");
            foreach(int element in tablica)
                Console.Write("{0} ", element);
            Console.ReadKey(true);
        }
    }
}
