using System;

namespace Petla_for_dodatkowe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for.

            int h;
            Console.Write("Podaj wysokość: ");
            h = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((i * j) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
