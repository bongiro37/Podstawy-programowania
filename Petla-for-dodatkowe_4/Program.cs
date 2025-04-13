using System;

namespace Petla_for_dodatkowe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta
            prostokątnego jak na poniższym przykładzie. Użyj pętli for.
            */

            int n;
            Console.Write("Podaj liczbę naturalną n: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 4)
            {
                Console.WriteLine("Liczba musi być większa niż 4.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("X");
                }
                else if (i == n)
                {
                    for (int j = 1; j <= n; j++)
                        Console.Write("X");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("X");
                    for (int j = 1; j <= i - 2; j++)
                        Console.Write(" ");
                    Console.WriteLine("X");
                }
            }
            Console.ReadKey(true);
        }
    }
}
