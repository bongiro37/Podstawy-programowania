using System;

namespace Petla_for_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wypisujący na ekranie kolejne liczby całkowite od 11 do 33.Użyj pętli for.

            int i;
            for (i = 11; i <= 33; i++)
                Console.Write("{0}, ", i);
            Console.ReadKey(true);
        }
    }
}
