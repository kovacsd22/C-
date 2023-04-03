using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekSzoguHaromszogE
{
    internal class Program
    {
        /// <summary>
        /// Derékszögű háromszög megállapítását szolgáló eljárás
        /// </summary>
        /// <param name="a">a oldal értéke</param>
        /// <param name="b">b oldal értéke</param>
        /// <param name="c">c oldal értéke</param>
        public static void DerekSzoguHaromszogEAdatBekeresNelkul(int a,int b,int c)
        {
            bool aze = false;
            if ((a * a) + (b * b) == (c * c) || (a * a) + (c * c) == (b * b) || (c * c) + (b * b) == (a * a))
            {
                aze = true;
            }
            Console.WriteLine(aze?"Ez egy derékszögű háromszög":"Ez nem egy derékszögű háromszög");
        }

        public static void DerekSzoguHaromszogEAdatBekeressel()
        {
            Console.Write("Kérem a háromszög 'a' oldalát: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a háromszög 'b' oldalát: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Kérem a háromszög 'c' oldalát: ");
            int c = int.Parse(Console.ReadLine());
            bool aze = false;
            if ((a * a) + (b * b) == (c * c) || (a * a) + (c * c) == (b * b) || (c * c) + (b * b) == (a * a))
            {
                aze = true;
            }
            Console.WriteLine(aze?"Ez egy derékszögű háromszög":"Ez nem egy derékszögű háromszög");
        }
        static void Main(string[] args)
        {
            DerekSzoguHaromszogEAdatBekeresNelkul(2, 4, 6);
            DerekSzoguHaromszogEAdatBekeressel();

            Console.ReadKey();
        }
    }
}
