using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatosLotto
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] sajatSzamok = new int[6] {12, 36, 25, 19, 4, 8};
            int[] gepiSzamok = new int[6];
            int db = 0;
            while (db < 6)
            {
                int sorsoltSzam = rnd.Next(1, 46);
                if (!gepiSzamok.Contains(sorsoltSzam))
                {
                    gepiSzamok[db] = sorsoltSzam;
                    db++;
                }
            }
            foreach (int szam in gepiSzamok)
            {
                Console.Write(szam + " ");
            }

            Console.WriteLine();

            foreach (int szam in sajatSzamok)
            {
                Console.Write(szam + " ");
            }

            Console.WriteLine();
            int talalatokSzama = 0;
            foreach (int szam in sajatSzamok)
            {
                if (gepiSzamok.Contains(szam))
                {
                    talalatokSzama++;
                }
            }
            Console.WriteLine($"A találatok száma: {talalatokSzama}");

            Console.ReadKey();
        }
    }
}
