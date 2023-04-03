using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace KarakterGeneralas
{
    internal class Program
    {
        static Random rnd = new Random();

        static int KarakterGeneralas(string szoveg1, string szoveg2)
        {
            int eredmeny = szoveg1.CompareTo(szoveg2);

            if (eredmeny == -1)
            {
                Console.WriteLine("szoveg2 a nagyobb");
            }

            if (eredmeny == 0)
            {
                Console.WriteLine("szoveg1 és szoveg2 ugyan akkora");
            }

            if (eredmeny == 1)
            {
                Console.WriteLine("szoveg1 a nagyobb");
            }

            return eredmeny;
        }
        static void Main(string[] args)
        {
            string szoveg1 = "";
            string szoveg2 = "";

            for (int i = 0; i < 5; i++)
            {
                szoveg1 += rnd.Next(100, 300);
            }

            for (int j = 0; j < 3; j++)
            {
                szoveg2 += rnd.Next(12213, 34217);
            }

            Console.WriteLine($"Első szöveg: {szoveg1}");
            Console.WriteLine($"Második szöveg: {szoveg2}");

            Console.WriteLine(KarakterGeneralas(szoveg1,szoveg2));

            Console.ReadKey();
        }
    }
}
