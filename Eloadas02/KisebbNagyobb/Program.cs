using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisebbNagyobb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Első: ");
            int szam = int.Parse(Console.ReadLine());
            Console.Write("Második: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam > szam2)
            {
                Console.WriteLine("Szam nevű változó értéke nagyobb!");
            }
            else if (szam < szam2) 
            {
                Console.WriteLine("Szam2 nevű változó értéke nagyobb!");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }

            Console.ReadKey();
        }
    }
}
