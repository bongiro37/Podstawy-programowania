using System;

namespace Metody_4
{
    internal class Program
    {
        /*
        Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
        argument tej funkcji. Napisz program wykorzystujący funkcję ile_cyfr.
        */

        static int ile_cyfr(int n)
        {
            int i = 0;
            while (n/10>0)
            {
                n /= 10;
                i++;
            }
            return i + 1;
        }

        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę naturalną: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczba cyfr w liczbie {0} wynosi {1}", a, ile_cyfr(a));
            Console.ReadKey(true);
        }
    }
}
