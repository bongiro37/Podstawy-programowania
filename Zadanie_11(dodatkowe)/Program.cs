using System;

namespace Zadanie_11_dodatkowe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący długości boków prostopadłościanu i wypisujący na ekranie jego
            objętość i pole całkowite.
            */

            int a, b, c, obj, pc;
            Console.Write("Podaj długość boku a: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj długość boku b: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj długość boku c: ");
            c=Convert.ToInt32(Console.ReadLine());
            obj = a * b * c;
            pc = (2 * a * b) + (2 * a * c) + (2 * b * c);
            Console.WriteLine("Objętość prostopadłościanu wynosi: {0}", obj);
            Console.WriteLine("Pole całkowite prostopadłościanu wynosi: {0}", pc);
            Console.ReadKey(true);
        }
    }
}
