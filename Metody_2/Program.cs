using System;

namespace Metody_2
{
    internal class Program
    {
        /*
        Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
        zadanych jako argumenty tej funkcji. Napisz program wykorzystujący funkcję max.
        */

        static double max(double a, double b)
        {
            if (a > b) return a;
            else return b;
        }
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Podaj pierwsza liczbe: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj druga liczbe: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Liczbą większą (maksimum) z tych liczb jest {0}", max(a, b));
            Console.ReadKey(true);
        }
    }
}
