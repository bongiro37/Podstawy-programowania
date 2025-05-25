using System;

namespace Tablice_Dodatkowe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb naturalnych i wypisujący na ekranie
            wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj
            pętli foreach.
            */

            Console.Write("Podaj liczbę elementów (1-1000): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 || n > 1000)
            {
                Console.WriteLine("Liczba elementów musi być w przedziale 1-1000.");
                return;
            }
            int[] liczby = new int[n];
            int licznikParzystych = 0;

            Console.WriteLine("Podaj {0} liczb naturalnych:", n);
            for (int i = 0; i < n; i++)
            {
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba < 0)
                {
                    Console.WriteLine("Liczba musi być naturalna (>= 0).");
                    return;
                }

                liczby[i] = liczba;
            }
            for (int i = 0; i < n; i++)
            {
                if (liczby[i] % 2 == 0)
                {
                    licznikParzystych++;
                }
            }
            int[] parzyste = new int[licznikParzystych];
            int indeks = 0;
            for (int i = 0; i < n; i++)
            {
                if (liczby[i] % 2 == 0)
                {
                    parzyste[indeks] = liczby[i];
                    indeks++;
                }
            }
            for (int i = 0; i < parzyste.Length - 1; i++)
            {
                for (int j = 0; j < parzyste.Length - i - 1; j++)
                {
                    if (parzyste[j] > parzyste[j + 1])
                    {
                        int temp = parzyste[j];
                        parzyste[j] = parzyste[j + 1];
                        parzyste[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Parzyste liczby w kolejności niemalejącej:");
            foreach (int liczba in parzyste)
            {
                Console.WriteLine(liczba);
            }
            Console.ReadKey(true);
        }
    }
}
