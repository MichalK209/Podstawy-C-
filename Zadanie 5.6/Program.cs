using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._6
{
    internal class Program
    {
        //Napisać procedurę (czyli funkcję, która nie zwraca żadnej wartości) posiadającą trzy
        //parametry: a-długość boku kwadratu, znak1-znak będący konturem kwadratu, znak2-znak
        //będący wypełnieniem kwadratu.Procedura ma rysować na ekranie kwadrat o zadanych
        //argumentach. Przetestuj działanie utworzonej procedury.
        static void kwadrat(int a, char znak1, char znak2)
        {
            int i, j;
            for (i = 1; i <= a; i++) Console.WriteLine(znak1);
            Console.WriteLine("");
            for (i=2; i <= a-1; i++)
            {
                Console.WriteLine(znak1);
                for (j = 2; j <= a - 1; i++) Console.WriteLine(znak2);
                Console.Write(znak1);
                Console.WriteLine("");
            }
            for (i = 1; i <= a; i++) Console.WriteLine(znak1);     
        }
        
        static void Main(string[] args)
        {
            kwadrat(6, '#', '*');
            Console.ReadKey(true);
        }
    }
}
