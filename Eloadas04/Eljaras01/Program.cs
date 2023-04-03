using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljaras01
{
    internal class Program
    {
        public static void TeglalapTeruleteAdatBekeressel()
        {
            Console.Write("Kérem a téglalap 'a' oldalát: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a téglalap 'b' oldalát: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A téglalap területe: {a * b}");
        }

        /// <summary>
        /// A téglalap 'a' és 'b' oldalait tartalmazza ez a paraméter
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void TeglalapTeruleteAdatBekeresNelkul(int a,int b)
        {
            Console.WriteLine($"A téglalap területe: {a * b}");
        }
        static void Main(string[] args)
        {
            TeglalapTeruleteAdatBekeressel();
            TeglalapTeruleteAdatBekeresNelkul(8, 7);

            Console.ReadKey();
        }
    }
}
