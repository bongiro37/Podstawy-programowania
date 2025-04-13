using System;

namespace Zadanie_10_dodatkowe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący promień koła i wypisujący na ekranie jego pole i obwód.

            double a, pole, obw;
            Console.Write("Podaj promień koła: ");
            a=Convert.ToDouble(Console.ReadLine());
            pole = Math.PI * Math.Pow(a, 2);
            obw = 2 * Math.PI * a;
            Console.WriteLine("Pole koła wynosi: {0}", pole);
            Console.WriteLine("Obwód koła wynosi: {0}", obw);
            Console.ReadKey(true);
        }
    }
}
