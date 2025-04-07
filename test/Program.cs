using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            //całkowitymi. Napisz program wykorzystujący funkcję suma.

            static int suma(int a, int b)
            {
                return a + b;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Podaj pierwszą liczbę:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę:");
                int b = Convert.ToInt32(Console.ReadLine());
                int wynik = suma(a, b);
                Console.WriteLine($"Suma {a} i {b} wynosi: {wynik}");
            }

        }
    }
}
