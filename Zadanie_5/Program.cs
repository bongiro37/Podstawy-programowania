using System;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący promień podstawy(r) i wysokość(h) stożka i wypisujący na
            ekranie objętość i pole całkowite tego stożka.
            */
            double r, h, l, V, Pc;
            Console.Write("Podaj promien podstawy: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokosc stozka: ");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h); // tworząca stożka
            V = 1.0 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("Objetosc stozka wynosi: {0}", V);
            Console.WriteLine("Pole calkowite stozka wynosi: {0}", Pc);
            Console.ReadKey(true);
        }
    }
}
