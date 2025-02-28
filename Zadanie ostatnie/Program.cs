using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_ostatnie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            //największej z tych liczb.
            double a, b, c, d, e, min, max;
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj czwartą liczbę:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj piątą liczbę:");
            e = Convert.ToDouble(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Minimalną liczbą ze wszystkich wpisanych jest {0}", min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Maksymalną liczbą ze wszystkich wpisanych jest {0}", max);
            Console.ReadKey(true);



        }
    }
}
