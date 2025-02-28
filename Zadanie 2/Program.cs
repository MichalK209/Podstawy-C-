using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
            //dodatnia, ujemna, czy też równa zero.
            int a;
                Console.WriteLine("Podaj liczbę jakąś, jaką chcesz c;");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
                Console.WriteLine("Liczba, którą wpisałeś to zero!!");
            else
                if (a <= 0)
                Console.WriteLine("Liczba, którą wpisałeś jest ujemna! :c");
            else
                Console.WriteLine("Liczba, którą wpisałeś jest dodatnia! c:");
            Console.ReadKey(true);
        }
    }
}
