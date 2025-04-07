using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._3
{
    internal class Program
    {
        //Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
        //obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.
        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj promień koła:");
            double r = Convert.ToDouble(Console.ReadLine());
            double wynik = pole_kola(r);
            Console.WriteLine("Pole koła o promieniu {0} wynosi: {1}", r, wynik);
            Console.ReadKey(true);
        }
    }
}