using System;

namespace Struktury_2
{
    /*
    Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
    Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
    umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
    Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.
    */

    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] oceny;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uczen[] u;
            int ile_u, ile_ocen, i, j;
            Console.Write("Wprowadź liczbę uczniów w klasie: ");
            ile_u = Convert.ToInt32(Console.ReadLine());
            u = new Uczen[ile_u];
            for (i=0;i<ile_u;i++)
            {
                Console.Write("Wprowadź imię ucznia: ");
                u[i].imie = Console.ReadLine();
                Console.Write("Wprowadź nazwisko ucznia: ");
                u[i].nazwisko = Console.ReadLine();
                Console.Write("Wprowadź liczbę ocen ucznia {0} {1}: ", u[i].imie, u[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                u[i].oceny = new byte[ile_ocen];
                for (j=0;j<ile_ocen;j++)
                {
                    Console.Write("Wprowadź ocenę numer {0}: ", j + 1);
                    u[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (i = 0; i < ile_u; i++)
            {
                Console.WriteLine("Uczeń {0} {1} ma następujące oceny: ", u[i].imie, u[i].nazwisko);
                foreach (byte x in u[i].oceny)
                {
                    Console.Write("{0} ", x);
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);

        }
    }
}
