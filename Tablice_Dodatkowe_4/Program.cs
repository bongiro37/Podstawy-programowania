using System;


namespace Tablice_Dodatkowe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            informację ile liczb jest dodatnich, ujemnych i równych zero.
            */

            Console.Write("Podaj liczbę elementów (1-1000): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 1000)
            {
                Console.WriteLine("Liczba elementów musi być w przedziale 1-1000.");
                return;
            }

            int[] liczby = new int[n];
            int dodatnie = 0;
            int ujemne = 0;
            int zera = 0;

            Console.WriteLine("Podaj {0} liczb całkowitych:", n);
            for (int i = 0; i < n; i++)
            {
                liczby[i] = Convert.ToInt32(Console.ReadLine());

                if (liczby[i] > 0)
                    dodatnie++;
                else if (liczby[i] < 0)
                    ujemne++;
                else
                    zera++;
            }

            Console.WriteLine("Liczb dodatnich: {0}", dodatnie);
            Console.WriteLine("Liczb ujemnych: {0}", ujemne);
            Console.WriteLine("Liczb równych zero: {0}", zera);

            Console.ReadKey(true);
        }
    }
}
