using System;


namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.

            double a, b;
            Console.Write("Podaj bok a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj bok b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole prostokata: {0}", a * b);
            Console.WriteLine("Obwod prostokata: {0}", 2 * a + 2 * b);
            Console.ReadKey(true);
        }
    }
}
