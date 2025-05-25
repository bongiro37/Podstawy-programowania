using System;


namespace _1
{
    internal class Program
    {
        /*
        Napisz funkcję posiadającą dwa argumenty: p, q – długości przekątnych deltoidu. Funkcja ma
        zwracać pole deltoidu dla zadanych argumentów. Napisz program testujący utworzoną
        funkcję.
        */

        static double PoleDeltoidu(double p, double q)
        {
            return 0.5 * p * q;
        }

        static void Main()
        {
            double pole;
            Console.Write("Podaj długość przekątnej p: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość przekątnej q: ");
            double q = Convert.ToDouble(Console.ReadLine());

            if (p <= 0 || q <= 0)
            {
                Console.WriteLine("Długości przekątnych muszą być większe od zera.");
                return;
            }

            pole = PoleDeltoidu(p, q);

            Console.WriteLine("Pole deltoidu wynosi: {0}", pole);
            Console.ReadKey(true);
        }
    }
}

