using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FuggvenyekIsmetles
{
    internal class Program
    {
        static Random rnd = new Random(); // Véletlenszám generálásához példányosítás a Random osztályból !!!Elég egy a programba!!!
        /// <summary>
        /// Két szöveg összehasonlítása függvény
        /// </summary>
        /// <param name="nev1">Szöveg 1</param>
        /// <param name="nev2">Szöveg 2</param>
        /// <returns>-1,0,1</returns>
        static int Osszehasonlit(string nev1, string nev2)
        {
            int eredmeny = nev1.CompareTo(nev2);
            return eredmeny;
            // -1 - nev1 van előrébb
            // 0 - a két név azonos
            // +1 - nev2 van előrébb
        }

        /// <summary>
        /// Teljes név létrehozása
        /// </summary>
        /// <param name="vezeteknev">Vezetéknév</param>
        /// <param name="keresztnev">Keresztnév</param>
        /// <returns>Vezetéknév és keresztnév</returns>
        static string Osszeadas(string vezeteknev, string keresztnev) 
        {
            string eredmeny = vezeteknev + " " + keresztnev;
            return eredmeny;
        }

        /// <summary>
        /// Betű keresése (index)
        /// </summary>
        /// <param name="szoveg">Ebben a szövegben keresek</param>
        /// <param name="keresettBetu">Ezt a betűt keresem</param>
        /// <returns>A szövegből való keresett betű</returns>
        static int Kereses(string szoveg, char keresettBetu)
        {
            int eredmeny = szoveg.IndexOf(keresettBetu);
            return eredmeny;
        }

        /// <summary>
        /// Betű kiírása index alapján a kapott szövegből
        /// </summary>
        /// <param name="szoveg">Bemeneti szöveg</param>
        /// <param name="index">Index érték</param>
        /// <returns>A szöveg indexedik eleme</returns>
        static string AdottBetuKiirasa(string szoveg, int index)
        {
            return szoveg[index].ToString();
        }

        /// <summary>
        /// Szövegrészlet kiírása
        /// </summary>
        /// <param name="szoveg">Bemeneti szöveg</param>
        /// <param name="kezdoPozicio">Index szerinti kezdőpozíció</param>
        /// <param name="hossz">Hány betű hosszan (nulla esetén végéig)</param>
        /// <returns>A szöveg megadott indexétől való kiíratás</returns>
        static string SzovegReszletKiirasa(string szoveg, int kezdoPozicio, int hossz)
        {
            if (hossz == 0)
            {
                return szoveg.Substring(kezdoPozicio);
            }
            else
            {
                return szoveg.Substring(kezdoPozicio,hossz);
            }
        }

        /// <summary>
        /// Véletlenszám generálás 1 paraméterrel (0 - paraméter-1-ig)
        /// </summary>
        /// <param name="db">Max szám érték</param>
        /// <returns>Random szám</returns>
        static double VeletlenSzamGeneralas(int db)
        {
            int veletlenSzam = rnd.Next(db);
            return veletlenSzam;
        }
        static void Main(string[] args)
        {
            Console.Write("Első név: ");
            string nev1 = Console.ReadLine();
            Console.Write("Második név: ");
            string nev2 = Console.ReadLine();
            int eredmeny1 = Osszehasonlit(nev1, nev2);
            Console.WriteLine($"Eredmény: {eredmeny1}");

            Console.WriteLine();

            Console.Write("Vezetéknév: ");
            string vezeteknev = Console.ReadLine();
            Console.Write("Keresztnév: ");
            string keresztnev = Console.ReadLine();
            string eredmeny2 = Osszeadas(vezeteknev, keresztnev);
            Console.WriteLine($"Eredmény: {eredmeny2}");

            Console.WriteLine();

            Console.Write("Szöveg: ");
            string szoveg1 = Console.ReadLine();
            Console.Write("Keresett betű: ");
            char betu = char.Parse(Console.ReadLine());
            int eredmeny3 = Kereses(szoveg1, betu);
            Console.WriteLine($"Eredmény: {eredmeny3}");

            Console.WriteLine();

            Console.Write("Szöveg: ");
            string szoveg2 = Console.ReadLine();
            Console.Write("Index: ");
            int index = int.Parse(Console.ReadLine());
            string eredmeny4 = AdottBetuKiirasa(szoveg2, index);
            Console.WriteLine($"Eredmény: {eredmeny4}");

            Console.WriteLine();
            Console.Write("Szöveg: ");
            string szoveg3 = Console.ReadLine();
            Console.Write("Kezdőpozíció: ");
            int kezdopozicio = int.Parse(Console.ReadLine());
            Console.Write("Hossz: ");
            int hossz = int.Parse(Console.ReadLine());
            string eredmeny5 = SzovegReszletKiirasa(szoveg3, kezdopozicio, hossz);
            Console.WriteLine($"Eredmény: {eredmeny5}");

            Console.WriteLine();

            Console.Write("Legnagyobb érték amit már nem tud kiírni: ");
            int db = int.Parse(Console.ReadLine());
            double eredmeny6 = VeletlenSzamGeneralas(db);
            Console.WriteLine($"Eredmény: {eredmeny6}");

            Console.ReadKey();
        }
    }
}
