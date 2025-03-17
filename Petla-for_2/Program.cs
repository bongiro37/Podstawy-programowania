using System;

namespace Petla_for_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący wartość liczby naturalnej n(n >= 0), obliczający wartość 2 ^ n(2 do
            potęgi n) i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2 ^ 10 = 1024.Do obliczenia
            wartości wyrażenia użyj pętli for.
            */

            int a, b = 1, n;
            Console.Write("Podaj liczbę naturalną n = ");
            n=Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= n; a++)
                b *= 2;
            Console.WriteLine("2^{0}={1}", n, b);
            Console.ReadKey(true);

        }
    }
}
