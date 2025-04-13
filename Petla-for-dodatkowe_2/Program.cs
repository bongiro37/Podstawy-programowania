using System;

namespace Petla_for_dodatkowe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać
            od użytkownika. Przykładowo dla n=3 należy obliczyć sumę 1+3+5.
            Do obliczenia wartości sumy użyj pętli for.
            */

            int n, suma, ln;
            Console.Write("Podaj liczbę wyrazów: ");
            n=Convert.ToInt32(Console.ReadLine());
            suma = 0;
            ln = 1;
            for(int i=0;i<n;i++)
            {
                suma += ln;
                ln += 2;
            }
            Console.WriteLine("Suma {0} początkowych liczb nieparzystych wynosi: {1}", n, suma);
            Console.ReadKey(true);
        }
    }
}
