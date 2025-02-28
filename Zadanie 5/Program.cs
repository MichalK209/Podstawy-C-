using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy(r) i wysokość(h) stożka i wypisujący na
            //ekranie objętość i pole całkowite tego stożka.
            double r, h, l, V, Pc;
            Console.WriteLine("Podaj r="); //to co chcemy wyświetlić
            r = Convert.ToDouble(Console.ReadLine()); //żeby przeczytał to co wpiszemy
            Console.WriteLine("Podaj h=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h); //definiujemy tworzącą
            V = 1.0 / 3 * Math.PI * r * r*h; //definiujemy objętość
            Pc = Math.PI * r * r + l* Math.PI * r; //definiujemy pole całkowite
            Console.WriteLine("Objętość={0}", V); //chcemy żeby zwrócił nam objętość i pole, czyli zdefiniowane wartości po przecinku
            Console.WriteLine("Pole całkowite={0}", Pc);
            Console.ReadKey(true);
        }
    }
}
