using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._5
{
    internal class Program
    {
        //Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
        //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
        //utworzonej funkcji.
        static int czy_pierwsza(int liczba)
        {
            int i;
            for (i = 2; i < liczba / 2; i++)
                if (liczba % i == 0) return 0;
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            if (czy_pierwsza(liczba) == 1)
                Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
            else
                Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", liczba);
            Console.ReadKey();
        }
    }
}