using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EljarasokIsmetles
{
    internal class Program
    {
        static Random rnd = new Random(); // Véletlenszám generálásához példányosítás a Random osztályból !!!Elég egy a programba!!!
        /// <summary>
        /// Két szöveg összehasonlítása
        /// </summary>
        /// <param name="nev1">Szöveg 1</param>
        /// <param name="nev2">Szöveg 2</param>
        static void Osszehasonlit(string nev1, string nev2)
        {
            int eredmeny = nev1.CompareTo(nev2);
            Console.WriteLine(eredmeny);
            // -1 - nev1 van előrébb
            // 0 - a két név azonos
            // +1 - nev2 van előrébb
        }

        /// <summary>
        /// Teljes név létrehozása
        /// </summary>
        /// <param name="vezeteknev">Vezetéknév</param>
        /// <param name="keresztnev">Keresztnév</param>
        static void Osszeadas(string vezetekNev, string keresztNev) 
        {
            string eredmeny = vezetekNev + " " + keresztNev; // konkatenálás
            Console.WriteLine(eredmeny);
        }

        /// <summary>
        /// Betű keresése (index)
        /// </summary>
        /// <param name="szoveg">Ebben a szövegben keresek</param>
        /// <param name="keresettBetu">Ezt a betűt keresem</param>
        static void Kereses(string szoveg, char keresettBetu)
        {
            int eredmeny = szoveg.IndexOf(keresettBetu);
            Console.WriteLine(eredmeny);
        }

        /// <summary>
        /// Betű kiírása index alapján a kapott szövegből
        /// </summary>
        /// <param name="szoveg">Bemeneti szöveg</param>
        /// <param name="index">Index érték</param>
        static void AdottBetuKiirasa(string szoveg, int index)
        {
            Console.WriteLine(szoveg[index]);
        }

        /// <summary>
        /// Szövegrészlet kiírása
        /// </summary>
        /// <param name="szoveg">Bemeneti szöveg</param>
        /// <param name="kezdoPozicio">Index szerinti kezdőpozíció</param>
        /// <param name="hossz">Hány betű hosszan (nulla esetén végéig)</param>
        static void SzovegReszletKiirasa(string szoveg, int kezdoPozicio, int hossz)
        {
            if (hossz == 0)
            {
                Console.WriteLine(szoveg.Substring(kezdoPozicio));
            }
            else
            {
                Console.WriteLine(szoveg.Substring(kezdoPozicio, hossz));
            }
        }

        #region Véletlenszám generálás 1 paraméterrel (0 - paraméter-1-ig)
        /// <summary>
        /// Véletlenszám generálás 1 paraméterrel (0 - paraméter-1-ig)
        /// </summary>
        /// <param name="db">Max szám érték</param>
        static void VeletlenSzamGeneralas(int db)
        {
            int veletlenSzam = rnd.Next(db);
            Console.WriteLine(veletlenSzam);
        }
        #endregion  
        static void Main(string[] args)
        {
            Osszehasonlit("Héjjas Gyula", "Szabó Judit");
            Osszeadas("Tóth", "Viktor");
            Kereses("Kiss Gergő", 's');
            AdottBetuKiirasa("Kelemen Ádám", 10);
            SzovegReszletKiirasa("Kovács Dániel", 7, 6);
            SzovegReszletKiirasa("Kovács Dániel", 7, 0);
            VeletlenSzamGeneralas(100);


            
            Console.ReadKey();
        }
    }
}
