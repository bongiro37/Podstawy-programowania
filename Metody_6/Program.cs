using System;
using System.Runtime.Serialization.Formatters;

namespace Metody_6
{
    internal class Program
    {
        /*
        Napisać procedurę (czyli funkcję, która nie zwraca żadnej wartości) posiadającą trzy
        parametry: a-długość boku kwadratu, znak1-znak będący konturem kwadratu, znak2-znak
        będący wypełnieniem kwadratu. Procedura ma rysować na ekranie kwadrat o zadanych
        argumentach. Przetestuj działanie utworzonej procedury. 
        */

        static void square(int a, char znak1, char znak2)
        {
            for (int i = 1; i <= a; i++) Console.Write(znak1);
            Console.WriteLine("");
            for (int j = 2; j <= a -1; j++)
            {
                Console.Write(znak1);
                for (int k = 2; k <= a - 1; k++) Console.Write(znak2);
                Console.Write(znak1);
                Console.WriteLine("");
            }
            for (int l = 1; l <= a; l++) Console.Write(znak1);
        }

        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj wielkość kwadratu: ");
            a = Convert.ToInt32(Console.ReadLine());
            square(a, '#', '*');
            Console.ReadKey(true);
        }
    }
}
