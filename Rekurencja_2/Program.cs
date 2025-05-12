using System;


namespace Rekurencja_2
{
    internal class Program
    {
        /*
        Napisz funkcję, która wyznacza n-ty wyraz ciągu Fibonacciego zadany przez argument
        wywołania funkcji wartości liczby naturalnej. Utwórz wersję rekurencyjną tej funkcji.
        Napisz program testowy wykorzystujący napisaną funkcję.
        */

        static long fibbonaci(long n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return fibbonaci(n - 1) + fibbonaci(n - 2);
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj n-ty wyraz ciągu Fibonacciego: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Błąd");
            else Console.WriteLine("{0} wyraz ciągu Fibonacciego to: {1}", n, fibbonaci(n));
            Console.ReadKey(true);
        }
    }
}
