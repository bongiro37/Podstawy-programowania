using System;

namespace Warunkowe_9_dodatkowe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dana jest funkcja kwadratowa f(x)=ax^2+bx+c. Napisać program wczytujący współczynniki
            funkcji kwadratowej (a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich
            braku
            */

            double a, b, c, delta, x1, x2, x0;
            Console.Write("Podaj współczynnik a: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współczynnik b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współczynnik c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a==0)
            {
                Console.WriteLine("Współczynnik a nie może być równy 0");
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta>0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Funkcja ma dwa miejsca zerowe: x1={0}, x2={1}", x1, x2);
                }
                else if (delta==0)
                {
                    x0 = -b / (2 * a);
                    Console.WriteLine("Funkcja ma tylko jedno miejsce zerowe: x0={0}", x0);
                }
                else
                {
                    Console.WriteLine("Funkcja nie ma miejsc zerowych");
                }
            }
            Console.ReadKey(true);
        }
    }
}
