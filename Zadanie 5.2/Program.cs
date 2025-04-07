using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._2
{
    internal class Program
    {

        //Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych zadanych jako argumenty tej funkcji.
        //Napisz program wykorzystujący funkcję max.
        static double max(double a, double b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double b = Convert.ToDouble(Console.ReadLine());
            double wynik = max(a, b);
            Console.WriteLine($"Maksimum z {a} i {b} wynosi: {wynik}");
            Console.ReadKey(true);

        }

      


        
    }
}
