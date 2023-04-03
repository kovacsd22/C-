using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖtösLottó
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            for ( ; ; )
            {
                int sajatSzam1 = 1;
                int sajatSzam2 = 23;
                int sajatSzam3 = 32;
                int sajatSzam4 = 57;
                int sajatSzam5 = 78;
                int gepiSzam1 = rnd.Next(90) + 1;
                int gepiSzam2 = rnd.Next(90) + 1;
                int gepiSzam3 = rnd.Next(90) + 1;
                int gepiSzam4 = rnd.Next(90) + 1;
                int gepiSzam5 = rnd.Next(90) + 1;
                Console.WriteLine($"Saját számok: {sajatSzam1},{sajatSzam2},{sajatSzam3},{sajatSzam4},{sajatSzam5}");
                Console.WriteLine($"Gépi számok: {gepiSzam1},{gepiSzam2},{gepiSzam3},{gepiSzam4},{gepiSzam5}");
                int db = 0;
                int szamlalo = 0;
                if (sajatSzam1 == gepiSzam1 || sajatSzam1 == gepiSzam2 || sajatSzam1 == gepiSzam3 || sajatSzam1 == gepiSzam4 || sajatSzam1 == gepiSzam5)
                {
                    db++;
                }
                if (sajatSzam2 == gepiSzam1 || sajatSzam2 == gepiSzam2 || sajatSzam2 == gepiSzam3 || sajatSzam2 == gepiSzam4 || sajatSzam2 == gepiSzam5)
                {
                    db++;
                }
                if (sajatSzam3 == gepiSzam1 || sajatSzam3 == gepiSzam2 || sajatSzam3 == gepiSzam3 || sajatSzam3 == gepiSzam4 || sajatSzam3 == gepiSzam5)
                {
                    db++;
                }
                if (sajatSzam4 == gepiSzam1 || sajatSzam4 == gepiSzam2 || sajatSzam4 == gepiSzam3 || sajatSzam4 == gepiSzam4 || sajatSzam4 == gepiSzam5)
                {
                    db++;
                }
                if (sajatSzam5 == gepiSzam1 || sajatSzam5 == gepiSzam2 || sajatSzam5 == gepiSzam3 || sajatSzam5 == gepiSzam4 || sajatSzam5 == gepiSzam5)
                {
                    db++;
                }
                szamlalo++;
                Console.WriteLine($"Találatok száma: {db}");

                Console.WriteLine();

                if (db == 5)
                {
                    Console.WriteLine($"Saját számok: {sajatSzam1},{sajatSzam2},{sajatSzam3},{sajatSzam4},{sajatSzam5}");
                    Console.WriteLine($"Gépi számok: {gepiSzam1},{gepiSzam2},{gepiSzam3},{gepiSzam4},{gepiSzam5}");
                    Console.WriteLine($"Találatok száma: {db}");
                    Console.WriteLine($"Sorsolások száma: {szamlalo}");
                }
            }

            //Console.WriteLine(((decimal)90 * 89 * 88 * 87 * 86 / (1 * 2 * 3 * 4 * 5)));

            Console.ReadKey();
        }
    }
}
