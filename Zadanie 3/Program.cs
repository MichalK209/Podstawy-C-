using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            //największej z tych liczb.
            int a, b, c;
            Console.WriteLine("Podaj pierwszą liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c) && (b > c))
                Console.WriteLine("Liczba maksymalna z tych, które podałeś to {0}, a minimalna to {1}", a, c);
            else
                if ((b > a) && (b > c) && (a > c))
                Console.WriteLine("Liczba maksymalna z tych, które podałeś to {0}, a minimalna to {1}", b, c);
            else
                if ((a > b) && (a > c) && (c > b))
                Console.WriteLine("Liczba maksymalna z tych, które podałeś to {0}, a minimalna to {1}", a, b);
            else
                if ((b > a) && (b > c) && (c > a))
                Console.WriteLine("Liczba maksymalna z tych, które podałeś to {0}, a minimalna to {1}", b, a);
            else
                if ((c > b) && (c > a) && (b > a))
                Console.WriteLine("Liczba maksymalna z tych, które podałeś to {0}, a minimalna to {1}", c, a);
            else
                Console.WriteLine("Liczba maksymalna z tych, które podałeś to {0}, a minimalna to {1}", c, b);
            Console.ReadKey(true);
        }
    }
}
