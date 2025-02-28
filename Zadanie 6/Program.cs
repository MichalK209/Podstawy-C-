using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz.
            double a, b, suma, iloraz, iloczyn, różnica;
                Console.WriteLine("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            iloraz = a:b;
            różnica = a - b;
            iloczyn = a * b;
            Console.WriteLine();
        }
    }
}
