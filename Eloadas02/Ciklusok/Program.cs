using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //számláló ciklus
            //ismert a futásainak a száma
            //lehet, hogy egyszer sem fut le

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //elöltesztelő ciklus
            //futásainak a száma ismeretlen
            //lehet, hogy egyszer sem fut le

            int j = 0;
            while (j < 10)
            {
                Console.Write(j + " ");
                j++;
            }

            Console.WriteLine();

            //hátul tesztelős ciklus
            //futásainak a száma ismeretlen
            //egyszer legalább le fut

            int k = 0;
            do
            {
                Console.Write(k + " ");
                k++;
            }
            while (k < 10);

            Console.WriteLine();

            string szoveg = "Ez itt egy szöveg";
            foreach (char betu in szoveg)
            {
                Console.WriteLine(betu);
            }

            Console.WriteLine("-----------------------------");

            for (int l = 0; l < szoveg.Length; l++)
            {
                Console.WriteLine(szoveg[l]);
            }

            Console.WriteLine("-----------------------------");

            int m = 0;
            while (m < szoveg.Length) 
            {
                Console.WriteLine(szoveg[m]);
                m++;
            }

            Console.WriteLine("-----------------------------");

            int n = 0;
            do
            {
                Console.WriteLine(szoveg[n] + " ");
                n++;
            }
            while (n < szoveg.Length);

            Console.ReadKey();
        }
    }
}
