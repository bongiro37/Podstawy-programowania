using System;

namespace Tablice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            sumę wczytanych liczb.
            */

            int[] tablica = new int[1000];
            int a;
            int n, suma;

            Console.Write("Podaj ilość liczb: ");
            n=Convert.ToInt32(Console.ReadLine());
            for (a = 0; a < n; a++)
            {
                Console.Write("Podaj liczbę: ");
                tablica[a] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (a = 0; a < n; a++)
                suma += tablica[a];
            Console.Write("Suma liczb wynosi: {0}", suma);
            Console.ReadKey(true);
        }
    }
}
