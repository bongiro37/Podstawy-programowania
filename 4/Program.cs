using System;

namespace _4
{
    internal class Program
    {
        static int NWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int a, b, wynik;
            Console.WriteLine("Podaj pierwszą liczbę: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            b=Convert.ToInt32(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Liczby muszą być większe od zera.");
                return;
            }
            wynik = NWD(a, b);
            Console.WriteLine("NWD wynosi: {0}", wynik);
            Console.ReadKey(true);
        }
    }
}
