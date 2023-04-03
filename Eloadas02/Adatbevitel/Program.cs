using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbevitel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev;
            Console.Write("Kérem a neved: ");
            nev = Console.ReadLine();
            Console.WriteLine(nev);

            Console.WriteLine();

            Console.Write("Hány éves vagy: ");
            int eletKor;
            string eletKorSzoveg = Console.ReadLine();
            eletKor = int.Parse(eletKorSzoveg);
            Console.WriteLine(eletKor);

            Console.WriteLine();

            Console.Write("Félévi átlagod: ");
            double atlag = double.Parse(Console.ReadLine());
            Console.WriteLine(atlag);

            Console.WriteLine();

            Console.Write("2. félévet megkezdhetem? (true/false): ");
            bool folytat = bool.Parse(Console.ReadLine());
            Console.WriteLine(folytat);

            Console.WriteLine();

            Console.Write("Szereted a túróstésztát? (i/n): ");
            char turosTeszta = char.Parse(Console.ReadLine());
            Console.WriteLine(turosTeszta);
            if (turosTeszta == 'i')
            {
                int tesztaMennyiseg = 20;
                Console.WriteLine("Tészta súlya: " + tesztaMennyiseg + " dkg");
            }

            Console.ReadKey();
        }
    }
}
