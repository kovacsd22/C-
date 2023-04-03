using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juhasz_Balazs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal szam = 5.55m;
            double szam2 = 4.91;
            decimal szam3 = szam * (decimal)szam2;

            Console.WriteLine(szam3);

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i != 6);

            string nev = "Géza";
            foreach (char c in nev)
            {
                Console.WriteLine(c);
            }

            short szam4 = short.MaxValue;
            uint szam5 = uint.MaxValue;
            long szam6 = szam4 + szam5;
            Console.WriteLine(szam6);

            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j += 2;
            }

            int szam7 = 16;
            int szam8 = szam7 << 4;
            Console.WriteLine(szam7);
            Console.WriteLine(szam8);

            string szoveg = "Kandó Kálmán";
            Console.WriteLine(szoveg);
            Console.WriteLine(szoveg.Split(' ')[0]);

            sbyte szam9 = -100;
            ushort szam10 = 100;
            int szam11 = szam9 * szam10;
            Console.WriteLine(szam11);

            for (int k = 1; k < 11; k++)
            {
                Console.WriteLine(k);
            }

            char karakter1 = 'A';
            float szam12 = 1.0f;
            short szam13 = 100;
            int szam14 = 30;
            Console.WriteLine((double)szam13 / szam14);

            int l = 100;
            do
            {
                Console.WriteLine(l);
                l -= 5;
            } while (l >= 0);

            bool igaze = false;
            int m = 0;
            while (!igaze)
            {
                Console.WriteLine("Ez a while törzse!");
                if (m >= 10)
                {
                    igaze = true;
                }
                m++;
            }

            double szam15 = 95.4;

            double szam16 = 0;
            while (szam16 <= 1)
            {
                Console.WriteLine(szam16);
                szam16 += 0.1;
            }

            string szoveg1 = "MITISZK";
            Console.WriteLine(szoveg1.Substring(2, 2));
            Console.WriteLine(szoveg1.ToLower());

            ulong szam17 = 12345678;
            decimal szam18 = 1234567890.54444m;
            Console.WriteLine(szam17 / szam18);

            string szoveg2 = "Informatikai Technikum";
            for (int n = 0; n < szoveg2.Length; n += 2)
            {
                Console.WriteLine(szoveg2[n]);
            }

            bool igaze1 = true;
            bool igaze2 = false;
            if (igaze1 && !igaze2)
            {
                Console.WriteLine("\n Hello World!");
            }

            long szam19 = 20;
            ushort szam20 = 7;
            double szam21 = (double)szam19 / (double)szam20;
            Console.WriteLine(szam21);

            for (int o = 50; o < 201; o = o + 3)
            {
                Console.WriteLine(o);
            }

            string szoveg3 = "géza kék az ég";
            for (int p = 0; p < szoveg3.Length; p++)
            {
                Console.Write(szoveg3[szoveg3.Length - p - 1]);
            }

            byte szam22 = 128;
            Console.WriteLine(szam22 << 2);
            int szam23 = 100;
            while (szam23 <= 200)
            {
                if (szam23 % 7 == 0)
                {
                    Console.WriteLine(szam23);
                }

                szam23++;
            }

            string szoveg4 = "istvan";
            Console.WriteLine(szoveg4.ToUpper());

            double szam24 = 5.35;
            short szam25 = 15;
            bool logikai;
            logikai = false;
            do
            {
                Console.WriteLine(szam25);
                if (szam25 == 30)
                {
                    logikai = true;
                }
                szam25++;
            } while (!logikai);

            int szam26 = int.MinValue;
            ushort szam27 = ushort.MaxValue;
            Console.WriteLine(szam26 / (double)szam27);

            string szoveg5 = "Andrássy Gyula";
            int db = 0;
            for (int q = 0; q < szoveg5.Length; q++)
            {
                if (szoveg5[q] == 's')
                {
                    db++;
                }
            }
            Console.WriteLine(db);
            Console.WriteLine(szoveg5.Contains("Gyula"));

            long szam28 = 150;
            int szam29 = 70;
            long szam30 = szam28 % szam29;
            Console.WriteLine(szam30);
            for (int r = 100; r <= 200; r++)
            {
                if (r % 9 != 0)
                {
                    Console.WriteLine(r);
                }
            }

            string szoveg6 = "terem";
            Console.WriteLine(szoveg6[0]);
            Console.WriteLine(szoveg6[4]);

            sbyte szam31 = -5;
            uint szam32 = 35;
            char karakter2 = 'z';
            double szam33 = szam32 / szam31;
            Console.WriteLine(szam33);
            decimal szam34 = 15.5m;
            int szamlalo = 10;
            while (szamlalo < 31) 
            {
                if (szamlalo % 2 == 0)
                {
                    Console.WriteLine(szamlalo);
                }
                szamlalo++;
            }

            string szoveg7 = "Ez egy szöveges változó értéke";
            char karakter3 = 'r';
            foreach (char betu in szoveg7)
            {
                if (betu == karakter3)
                {
                    Console.WriteLine($"Találtam egy {karakter3} betűt.");
                }
            }

            bool logikai2 = false;
            uint szam35 = 129;
            uint szam36 = 1;
            Console.WriteLine(szam35 & szam36);

            int szam37 = 89;
            ushort szam38 = 55;
            bool logikai3 = false;
            decimal szam39 = 15.87m;
            for (int s = 60; s < 83; s++)
            {
                if (s % 2 != 0)
                {
                    Console.WriteLine(s);
                }
            }

            Console.WriteLine(szam37 / (double)szam38);

            Console.ReadKey();
        }
    }
}
