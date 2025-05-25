using System;

namespace Tablice_Dodatkowe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            sumę kwadratów wczytanych liczb.
            */

            Console.Write("Podaj liczbę elementów (1-1000): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 1000)
            {
                Console.WriteLine("Liczba elementów musi być w przedziale 1-1000.");
                return;
            }

            int[] liczby = new int[n];
            long sumaKwadratów = 0;

            Console.WriteLine("Podaj {0} liczb całkowitych:", n);
            for (int i = 0; i < n; i++)
            {
                liczby[i] = Convert.ToInt32(Console.ReadLine());
                sumaKwadratów += (long)liczby[i] * liczby[i]; // kwadrat liczby
            }

            Console.WriteLine("Suma kwadratów wynosi: {0} ", sumaKwadratów);
            Console.ReadKey(true);
        }
    }
}
