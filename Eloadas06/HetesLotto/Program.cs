using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetesLotto
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] sajatSzamok = new int[7] {12,30,18,6,23,9,11};
            int[] gepiSzamok = new int[7];

            int db = 0;
            while (db < 7) 
            {
                int sorsoltSzam = rnd.Next(1, 36);
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
            Console.WriteLine($"Találatok száma: {talalatokSzama}");

            Console.ReadKey();
        }
    }
}
