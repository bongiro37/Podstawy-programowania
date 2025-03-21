using System;

namespace Petla_for_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Spośród liczb od 1 do 100 wypisz na ekranie wszystkie liczby podzielne przez 13.Użyj pętli for

            int a;
            for (a = 13; a <= 100; a += 13)
            {
                    Console.WriteLine(a);
            }
            Console.ReadKey(true);
        }
    }
}
