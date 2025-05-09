using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program posiadający tablicę nazw owoców. Stwórz menu umożliwiające
//zrealizowanie operacji na tablicy: dodawanie nowych owoców, usuwanie istniejących
//owoców, modyfikowanie istniejących owoców, wyświetlanie listy owoców.
//Oprogramuj odpowiednio pozycje menu i sprawdź, czy program poprawnie działa.
namespace Zadanie_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            string[] owoce = new string[N];
            int ile = 0;
            int w, nr, i;
            do
            {
                Console.WriteLine("\nMENU:\n1: Dodaj\n2: Modyfikuj\n3: Usuń");
                Console.Write("\n4: Wypisz\n0: The End\nTwój wybór: ");
                w = Convert.ToInt32(Console.ReadLine());
                switch (w)
                {
                    case 0: break;
                    case 1:
                        Console.Write("Podaj nazwę owocu: ");
                        owoce[ile++] = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Podaj numer owocu do modyfikacji: ");
                        nr = Convert.ToInt32(Console.ReadLine());
                        if ((nr < ile) && (nr > 0))
                        {
                            Console.WriteLine($"Obecna nazwa owocu: {owoce[nr - 1]}");
                            Console.Write("Podaj nową nazwę owocu: ");
                            owoce[nr - 1] = Console.ReadLine();
                        }
                        else Console.WriteLine("Nie pasuje mi ten numer wariacie!");
                        break;
                    case 3:
                        if (ile == 0) Console.WriteLine("Nie ma owoców, sklep zamknięty");
                        else
                        {
                            Console.WriteLine("Podaj numer owocu do usunięcia");
                            nr = Convert.ToInt32(Console.ReadLine());
                            if ((nr <= ile) && (nr > 0))
                            {
                                Console.WriteLine($"Usunięto owoc {owoce[nr - 1]}");
                                if (ile == 1) ile = 0;
                                else
                                {
                                    for (i = nr - 1; i < ile; i++) owoce[i] = owoce[i + 1];
                                    ile--;
                                }
                            }
                            else Console.WriteLine("Zły numer aaaa");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Wypisane owoce: ");
                        for (i = 0; i < ile; i++)
                            Console.WriteLine($"{i + 1}. {owoce[i]}");
                        break;
                    default: Console.WriteLine("Nieznany wybór nwm o co chodzi"); break;
                }
            } while (w != 0);

            Console.ReadKey(true);
        }
    }
}
