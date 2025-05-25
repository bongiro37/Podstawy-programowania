using System;


namespace _2
{
    internal class Program
    {
        /*
        Napisz funkcję, która posiada jeden parametr będący rokiem. Ma ona zwracać wartość 1, jeśli
        rok jest przestępny i 0 w pozostałych przypadkach. Napisz program testujący utworzoną
        funkcję.
        */

        static int CzyPrzestepny(int rok)
        {
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
                return 1;
            else
                return 0;
        }

        static void Main()
        {
            Console.Write("Podaj rok: ");
            int rok = Convert.ToInt32(Console.ReadLine());

            int wynik = CzyPrzestepny(rok);

            if (wynik == 1)
                Console.WriteLine("Rok {0} jest przestępny.", rok);
            else
                Console.WriteLine("Rok {0} nie jest przestępny.", rok);

        }
    }
}
