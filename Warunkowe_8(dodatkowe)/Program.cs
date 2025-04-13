using System;

namespace Warunkowe_8_dodatkowe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy
            da się z tych odcinków zbudować trójkąt, czy też nie
            */

            double a, b, c;
            Console.Write("Odcinek a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Odcinek b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Odcinek c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Z tych odcinków można zbudować trójkąt");
            }
            else Console.WriteLine("Z tych odcinków nie można zbudować trójkąta");
            Console.ReadKey(true);
        }
    }
}
