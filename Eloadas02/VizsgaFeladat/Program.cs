using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizsgaFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adja meg az első számot: ");
            int elsoSzam = int.Parse(Console.ReadLine());
            Console.Write("Kérem, adja meg a második számot: ");
            int masodikSzam = int.Parse(Console.ReadLine());

            if (elsoSzam == masodikSzam)
            {
                Console.WriteLine("A két szám egyenlő.");
            }
            else if (elsoSzam % masodikSzam == 0)
            {
                Console.WriteLine("A második szám osztója az elsőnek.");
            }
            else if (masodikSzam % elsoSzam == 0)
            {
                Console.WriteLine("Az első szám osztója a másodiknak.");
            }
            else
            {
                Console.WriteLine("Egyik sem osztója a másiknak.");
            }

            Console.ReadKey();
        }
    }
}
