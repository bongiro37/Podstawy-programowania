using System;


namespace ConsoleApp1
{
    internal class Program
    {
        /*
        Napisać funkcję, która posiada trzy argumenty będące współczynnikami a, b, c funkcji
        kwadratowej y = ax^2 + bx + c.Funkcja ma zwracać ilość pierwiastków zadanej funkcji
        kwadratowej.Napisz program testujący utworzoną funkcję.
        */

        static void funkcja_kwad (double a, double b, double c)
        {
            if (a == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe");
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste: x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Równanie ma jeden podwójny pierwiastek: x = {0} ", x);
            }
            else
            {
                Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
            }
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj parametr a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj parametr b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj parametr c: ");
            c = Convert.ToDouble(Console.ReadLine());

            funkcja_kwad(a, b, c);
            Console.ReadKey(true);
        }
    }
}
