using System;

namespace Zadanie_8_dodatkowe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dany jest ciąg arytmetyczny a(n)=3n-1. Napisać program wczytujący numer wyrazu ciągu (n) i
            wypisujący na ekranie jego wartość.
            */

            int n;
            Console.Write("Podaj numer wyrazu ciągu: ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wartość tego wyrazu ciągu to {0}", 3 * n - 1);
            Console.ReadKey(true);
        }
    }
}
