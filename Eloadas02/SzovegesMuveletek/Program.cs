using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzovegesMuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = "Balázs";
            int magassag = 175;
            Console.WriteLine($"{nev} {magassag} cm magas."); //beillesztéses kiírás
            Console.WriteLine(nev + " " + magassag + " cm magas."); //konkatenálás
            Console.WriteLine("{0} {1} cm magas.",nev,magassag); //indexes beillesztéses kiírás
            Console.WriteLine(nev[0]);
            Console.WriteLine(nev.Substring(0,1));
            Console.WriteLine(nev.Substring(3));
            Console.WriteLine(nev.Substring(2,2));
            Console.WriteLine(nev.ToUpper());
            Console.WriteLine(nev.ToLower());
            Console.WriteLine(nev.Replace('a','ö'));
            foreach (char betu in nev)
            {
                Console.WriteLine(betu);
            }
            string magassagSzoveges = magassag.ToString();
            Console.WriteLine(magassagSzoveges);

            Console.ReadKey();
        }
    }
}
