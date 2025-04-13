using System;

namespace Zadanie_9_dodatkowe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów
            wczytanych liczb.
            */

            double a, b, a2, b2;
            Console.Write("Podaj liczbe a: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbe b: ");
            b=Convert.ToDouble(Console.ReadLine());
            a2 = Math.Pow(a, 2);
            b2 = Math.Pow(b, 2);
            Console.WriteLine("Suma kwadratów wczytanych liczb to: {0}", a2 + b2);
            Console.ReadKey(true);
        }
    }
}
