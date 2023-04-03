using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorTeruletKerulet
{
    internal class Program
    {
        /// <summary>
        /// Kör kerületének a kiszámítása
        /// </summary>
        /// <param name="d">a kör átlója</param>
        /// <returns>Kör kerülete</returns>
        static double KorKerulet(double d)
        {
            return d * Math.PI;
        }

        /// <summary>
        /// Kör területének a kiszámítása
        /// </summary>
        /// <param name="d">a kör átlója</param>
        /// <returns>Kör területe</returns>
        static double KorTerulet(double d)
        {
            return Math.Pow(d/2,2) * Math.PI;
        }
        static void Main(string[] args)
        {
            Console.Write("Kérem a kör átlóját: ");
            double d = double.Parse(Console.ReadLine());
            double kerulet = KorKerulet(d);
            Console.WriteLine($"A kör kerülete: {kerulet}");
            double terulet = KorTerulet(d);
            Console.WriteLine($"A kör területe: {terulet}");

            Console.Read();
        }
    }
}
