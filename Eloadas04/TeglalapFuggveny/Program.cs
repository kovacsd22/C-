using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeglalapFuggveny
{
    internal class Program
    {
        /// <summary>
        /// Téglalap területének a kiszámítása 
        /// </summary>
        /// <param name="a">a oldal</param>
        /// <param name="b">b oldal</param>
        /// <returns>Téglalap területe</returns>
        static int Terulet(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Téglalap kerületének a kiszámítása
        /// </summary>
        /// <param name="a">a oldal</param>
        /// <param name="b">b oldal</param>
        /// <returns>Téglalap kerülete</returns>
        static int Kerulet(int a, int b)
        {
            return 2 * (a + b);
        }

        /// <summary>
        /// Téglalap átlójának a kiszámítása
        /// </summary>
        /// <param name="a">a oldal</param>
        /// <param name="b">b oldal</param>
        /// <returns>Téglalap átlója</returns>
        static double Atlo(double a, double b)
        {
            return Math.Sqrt(a * a + Math.Pow(b, 2));
        }
        static void Main(string[] args)
        {
            Console.Write("Kérem a téglalap 'a' oldalát: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a téglalap 'b' oldalát: ");
            int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"A téglalap területe: {a * b}");
            int terulet = Terulet(a, b);
            Console.WriteLine($"A téglalap területe: {terulet}");
            int t = Terulet(6, 8);
            Console.WriteLine($"A téglalap területe: {t}");
            int kerulet = Kerulet(a, b);
            Console.WriteLine($"A téglalap kerülete: {kerulet}");
            int k = Kerulet(6, 8);
            Console.WriteLine($"A téglalap kerülete: {k}");
            double atlo = Atlo(a, b);
            Console.WriteLine($"A téglalap átlója: {atlo}");

            Console.ReadKey();
        }
    }
}
