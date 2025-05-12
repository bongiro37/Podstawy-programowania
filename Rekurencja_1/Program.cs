using System;

namespace Rekurencja_1
{
    internal class Program
    {
        /*
        Napisz funkcję , która oblicza wartość silni z zadanej przez argument wywołania funkcji
        wartości liczby naturalnej. Utwórz wersję rekurencyjną tej funkcji.
        Napisz program testowy wykorzystujący napisaną funkcję. 
        */

        static long silnia(int n)
        {
            if (n == 0) return 1;
            else return n * silnia(n - 1);
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbę naturalną: ");
            n = Convert.ToInt32(Console.ReadLine());
            if 
                (n < 0) Console.WriteLine("Błąd");
            else 
                Console.WriteLine("{0}! = {1}", n, silnia(n));
            Console.ReadKey(true);
        }
    }
}
