using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeletlenSzamGeneralas
{
    internal class Program
    {
        static Random rnd = new Random();
        static Random rnd2 = new Random(); // ennek nincs értelme!
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(rnd.Next(200, 301) + " " + rnd2.Next(200,301));
            }

            Console.WriteLine();

            int veletlenszam = rnd.Next(100,1001);
            while (veletlenszam <= 975)
            {
                veletlenszam = rnd.Next(100,1001);
                Console.WriteLine(veletlenszam);
            }

            Console.ReadKey();
        }
    }
}
