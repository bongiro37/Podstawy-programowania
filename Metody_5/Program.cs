using System;

namespace Metody_5
{
    internal class Program
    {
        /*
        Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
        powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb. Przetestuj działanie
        utworzonej funkcji.
        */

        static int l_pierwsza(int n)
        {
            int i;
            for (i = 2; i < n / 2; i++)
                if (n % i == 0) return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (l_pierwsza(a) == 1)
                Console.WriteLine("Liczba {0} jest liczbą pierwszą", a);
            else
                Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", a);
            Console.ReadKey(true);
        }
    }
}
