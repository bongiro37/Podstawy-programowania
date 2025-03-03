using System;


namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian
                wczytanej liczby.
            */
            int a;
            Console.WriteLine("Podaj liczbe calkowita: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a^3 = {0}", a * a * a);
            Console.ReadKey(true);
        }
    }
}
