using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytane
            //liczby w odwrotnej kolejności na ekranie.
            int[] tab = new int[1000]; //tablica 1000 liczb typu int
            int i, n; //i-licznik pętli, n-ilość elementów tablicy

            //wczytuję n
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            //wczytuję n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //wyświetlam elementy tablicy na ekranie w odwrotnej kolejności
            Console.Write("Elementy tablicy: ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0}, ", tab[i]);
            }

            Console.ReadKey(true); //pauza

        }
    }
}
