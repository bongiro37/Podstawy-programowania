using System;


namespace Warunkowe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny
            czy też nie
            */

            int rok;
            Console.Write("Podaj rok: ");
            rok=Convert.ToInt32(Console.ReadLine());
            if (((rok % 4 == 0) && (rok % 100 != 0)) || (rok % 400 == 0))
                Console.WriteLine("Podany rok {0} jest przestępny", rok);
            else
                Console.WriteLine("Podany rok {0} nie jest przestępny", rok);
            Console.ReadKey(true);
        }
    }
}
