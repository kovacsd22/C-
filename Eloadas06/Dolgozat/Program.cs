using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisdolgozat_JuhászBalázs01
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int db = 0;
            for (int i = 0;i < 101; i++) 
            {
                int veletlen = rnd.Next(1, 300);
                Console.Write(veletlen + " ");

                if (veletlen % 7 == 0)
                {
                    db++;
                }
            }

            Console.WriteLine();

            Console.WriteLine("7-tel osztható számok (db): " + db);

            Console.WriteLine();

            int veletlen2 = rnd.Next(1500,9765);
            while (veletlen2 % 3 != 0 || veletlen2 % 7 != 0 || veletlen2 % 39 != 0)
            {
                veletlen2 = rnd.Next(1500, 9765);
                Console.Write(veletlen2 + " ");
            }

            Console.WriteLine();

            Console.WriteLine("A választott szám: " + veletlen2);
            

            Console.ReadKey();
        }
    }
}
