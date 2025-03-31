using System;

namespace Tablice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.

            int[] tablica = new int[1000];
            int a=0, b, n;
            Console.WriteLine("Podaj liczbę naturalną n: ");
            n=Convert.ToInt32(Console.ReadLine());

            while((n/2!=0) || (n/2==0) && (n%2!=-0))
            {
                tablica[a++]=n % 2;
                n /= 2;
            }
            for(b=a-1;b >= 0; b--)
                Console.Write(tablica[b]);
            Console.ReadKey(true);
        }
    }
}
