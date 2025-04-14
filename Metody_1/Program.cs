using System;

namespace Metody_1
{
    internal class Program
    {
        /*
        Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
        całkowitymi. Napisz program wykorzystujący funkcję suma 
        */
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Podaj pierwsza liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj druga liczbe: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, Suma(a, b));
            Console.ReadKey(true);
        }
    }
}
