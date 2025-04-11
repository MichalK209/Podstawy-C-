using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._4
{
    internal class Program
    {
        public Program()
        {
        }

        //Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
        //argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr.
        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczba cyfr w liczbie {0} wynosi {1}", liczba, ile_cyfr(liczba));
            Console.ReadKey();
        }
    }
}
