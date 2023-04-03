using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EljarasKorTerulete
{
    internal class Program
    {
        public static void KorTeruleteAdatBekeressel()
        {
            Console.Write("Kérem a kör sugarát: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"A kör területe: {(r * r) * 3.14}");
        }

        /// <summary>
        /// A kör sugarát tartalmazza ez a paraméter
        /// </summary>
        /// <param name="r"></param>
        public static void KorTeruleteAdatBekeresNelkul(int r)
        {
            Console.WriteLine($"A kör területe: {(r * r) * 3.14}");
        }
        static void Main(string[] args)
        {
            //Ez itt a kör területének a kódrésze
            /*Ez egy
            több soros komment*/
            KorTeruleteAdatBekeressel();
            KorTeruleteAdatBekeresNelkul(5);

            Console.ReadKey();
        }
    }
}
