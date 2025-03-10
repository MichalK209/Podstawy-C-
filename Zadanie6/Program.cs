using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący numer miesiąca(od 1 do 12) i wypisujący na ekranie nazwę tego
            //miesiąca.Użyj instrukcji wyboru switch.
            int miesiąc;
            Console.WriteLine("Podaj numer miesiąca:");
            miesiąc = Convert.ToInt32(Console.ReadLine());

            switch (miesiąc)
            {
                case 1: Console.WriteLine("Ten numer odpowiada Styczniowi!"); break;
                case 2: Console.WriteLine("Ten numer odpowiada Lutemu!"); break;
                case 3: Console.WriteLine("Ten numer odpowiada Marcowi!"); break;
                case 4: Console.WriteLine("Ten numer odpowiada Kwietniowi!"); break;
                case 5: Console.WriteLine("Ten numer odpowiada Majowi!"); break;
                case 6: Console.WriteLine("Ten numer odpowiada Czerwcowi!"); break;
                case 7: Console.WriteLine("Ten numer odpowiada Lipcowi!"); break;
                case 8: Console.WriteLine("Ten numer odpowiada Sierpniowi!"); break;
                case 9: Console.WriteLine("Ten numer odpowiada Wrześniowi!"); break;
                case 10: Console.WriteLine("Ten numer odpowiada Październikowi!"); break;
                case 11: Console.WriteLine("Ten numer odpowiada Listopadowi!"); break;
                case 12: Console.WriteLine("Ten numer odpowiada Grudniowi!"); break;
                default: Console.WriteLine("Taki miesiąc nie istnieje bratku"); break;
            }
             Console.ReadKey();
            }
                

        }
    }
