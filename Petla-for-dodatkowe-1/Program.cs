using System;
using System.Security.Cryptography;


namespace Petla_for_dodatkowe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            10.Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7.Ilość liczb
            wczytaj z klawiatury. Użyj pętli for. Oto wydruk dla ile = 6:
            0, 7, 14, 21, 28, 35
            */

            int ile, i;
            Console.Write("Podaj ile liczb podzielnych przez 7 chcesz podac: ");
            ile = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < ile; i++)
            {
                Console.Write(i * 7 + ", ");
            }
            Console.ReadKey(true);
        }
    }
}
