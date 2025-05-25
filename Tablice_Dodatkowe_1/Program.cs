using System;


namespace Tablice_Dodatkowe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            najmniejszą i największą wczytaną liczbę.
            */

            Console.Write("Podaj liczbę elementów (1-1000): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 1000)
            {
                Console.WriteLine("Liczba elementów musi być w przedziale 1-1000.");
                return;
            }

            int[] liczby = new int[n];

            Console.WriteLine("Podaj {0} liczb całkowitych:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Liczba {0}: ", i + 1);
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = liczby[0];
            int max = liczby[0];

            for (int i = 1; i < n; i++)
            {
                if (liczby[i] < min)
                    min = liczby[i];
                if (liczby[i] > max)
                    max = liczby[i];
            }

            Console.WriteLine("Najmniejsza liczba: " + min);
            Console.WriteLine("Największa liczba: " + max);

            Console.ReadKey(true);
        }
    }
}
