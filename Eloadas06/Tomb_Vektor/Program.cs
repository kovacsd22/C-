using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_Vektor
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int a = 1;
            int[] egeszSzamok = new int[16];
            foreach (int egySzam in egeszSzamok)
            {
                Console.WriteLine(egySzam);
            }

            Console.WriteLine();

            egeszSzamok[1] = 34;

            for (int i = 0; i < 16; i++)
            {
                egeszSzamok[i] = random.Next(1,5);
            }

            foreach (int egySzam in egeszSzamok)
            {
                Console.WriteLine(egySzam);
            }

            Console.WriteLine();

            string[] OsztalyTanuloi = new string[30];
            OsztalyTanuloi[0] = "Juhász Balázs";
            OsztalyTanuloi[29] = "Kelemen Ádám";
            OsztalyTanuloi[14] = "Csitári Ádám János";
            OsztalyTanuloi[15] = "Héjjas Gyula";
            foreach (string egyTanulo in OsztalyTanuloi)
            {
                Console.WriteLine(egyTanulo);
            }

            OsztalyTanuloi[15] = "Dimény Soma Dominik";
            foreach (string egyTanulo in OsztalyTanuloi)
            {
                Console.WriteLine(egyTanulo);
            }

            Console.WriteLine();

            bool[] AgazatiVizsgaEredmenye = new bool[30];
            AgazatiVizsgaEredmenye[0] = true;
            AgazatiVizsgaEredmenye[1] = true;
            AgazatiVizsgaEredmenye[15] = true;
            AgazatiVizsgaEredmenye[29] = true;
            foreach (bool item in AgazatiVizsgaEredmenye)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
