using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeglaTest
{
    internal class Program
    {
        /// <summary>
        /// Téglatest felületének a kiszámítása paraméterek nélkül
        /// </summary>
        static void TeglaTestFelulete()
        {
            Console.Write("Kérem a tégla 'a' oldalának a méretét: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a tégla 'b' oldalának a méretét: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Kérem a tégla 'c' oldalának a méretét: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"A téglatest felszíne: {(a * b + a * c + b * c) * 2}");
        }

        /// <summary>
        /// Téglatest felületének a kiszámítása paraméterekkel
        /// </summary>
        /// <param name="a">a-Szélesség</param>
        /// <param name="b">b-Magasság</param>
        /// <param name="c">c-Hosszúság</param>
        static void TeglaTestFelulete(int a,int b,int c)
        {
            Console.WriteLine($"A téglatest felszíne: {(a * b + a * c + b * c) * 2}");
        }
        static void Main(string[] args)
        {
            TeglaTestFelulete();
            TeglaTestFelulete(12, 6, 25);

            Console.ReadKey();
        }
    }
}
