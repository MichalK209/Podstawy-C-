using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
//Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
//umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
//Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.
namespace Zadanie_6._2
{
    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] oceny;
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Uczen[] uczniowie;
            int ile_uczniow, ile_ocen, i, j;
            Console.Write("Podaj liczbę uczniów w klasie:");
            ile_uczniow = Convert.ToInt32(Console.ReadLine());
            uczniowie = new Uczen[ile_uczniow];
            for (i=0; i < ile_uczniow; i++)
            {
                Console.WriteLine($"Podaj imie ucznia {i+1}:");
                uczniowie[i].imie = Console.ReadLine();
                Console.WriteLine($"Podaj nazwisko ucznia {i+1}:");
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.WriteLine($"Ile ocen ma {uczniowie[i].imie} {uczniowie[i].nazwisko}?");
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                uczniowie[i].oceny = new byte[ile_ocen];
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.WriteLine($"Podaj ocenę numer {j+1}");
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine("");
            }
            for (i = 0; i < ile_uczniow; i++ )
            {
                Console.Write($"{i+1}. {uczniowie[i].imie}, {uczniowie[i].nazwisko}:");
                foreach (byte o in uczniowie[i].oceny)
                    Console.WriteLine($"{o}, ");
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
