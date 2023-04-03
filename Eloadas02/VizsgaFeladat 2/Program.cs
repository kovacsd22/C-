using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizsgaFeladat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adjon meg egy 10 és 90 közötti összeget: ");
            string szam = Console.ReadLine();
            if (int.Parse(szam) < 10 || int.Parse(szam) > 90)
            {
                Console.WriteLine("10 és 90 közötti számot kértem.");
            }
            else if (szam[1] == '0')
            {
                Console.WriteLine("Készpénzben ez az összeg " + szam[0] + "0 Ft");
            }
            else if (szam[1] == '1' || szam[1] == '2')
            {
                Console.WriteLine("Készpénzben ez az összeg "+ szam[0] + "0 Ft");
            }
            else if (szam[1] == '3' || szam[1] == '4')
            {
                Console.WriteLine("Készpénzben ez az összeg " + szam[0] + "5 Ft");
            }
            else if (szam[1] == '5')
            {
                Console.WriteLine("Készpénzben ez az összeg " + szam[0] + "5 Ft");
            }
            else if (szam[1] == '6' || szam[1] == '7')
            {
                Console.WriteLine("Készpénzben ez az összeg " + szam[0] + "5 Ft");
            }
            else if (szam[1] == '8' || szam[1] == '9')
            {
                Console.WriteLine("Készpénzben ez az összeg {0}", int.Parse(szam[0].ToString()) + 1 + "0 Ft");
            }

            Console.ReadKey();
        }
    }
}
