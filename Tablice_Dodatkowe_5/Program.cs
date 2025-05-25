using System;

namespace Tablice_Dodatkowe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie ósemkowym.

            Console.Write("Podaj liczbę naturalną: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("To nie jest liczba naturalna!");
                return;
            }
            if (n == 0)
            {
                Console.WriteLine("Liczba w systemie ósemkowym: 0");
                return;
            }
            int[] cyfry = new int[32];
            int indeks = 0;
            int liczba = n;
            while (liczba > 0)
            {
                cyfry[indeks] = liczba % 8;
                liczba = liczba / 8;
                indeks++;
            }

            Console.Write("Liczba w systemie ósemkowym: ");
            for (int i = indeks - 1; i >= 0; i--)
            {
                Console.Write(cyfry[i]);
            }

            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
