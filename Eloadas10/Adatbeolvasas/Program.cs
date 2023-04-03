using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csv2Matrix
{
    internal class Program
    {
        static bool HianyosNev(string vegpontNev, char pecseteloHely)
        {
            if (pecseteloHely == 'i' && !vegpontNev.Contains("pecsetelohely"))
            {
               return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("kektura.csv");

            int sorokszama = 0;

            string egySor = "";

            Queue<string> adatBazis = new Queue<string>();

            while (!reader.EndOfStream)
            {
                egySor = reader.ReadLine();
                adatBazis.Enqueue(egySor);
                sorokszama++;
            }

            string[] mezok = egySor.Split(';');

            Console.WriteLine($"Sorok száma: {sorokszama} Oszlopok száma: {mezok.Length}");
            reader.Close();

            string[,] adatok = new string[sorokszama, mezok.Length];

            for (int i = 0; i < sorokszama; i++)
            {
                mezok = adatBazis.Dequeue().Split(';');
                adatok[i, 0] = mezok[0];
                adatok[i, 1] = mezok[1];
                adatok[i, 2] = mezok[2];
                adatok[i, 3] = mezok[3];
                adatok[i, 4] = mezok[4];
                adatok[i, 5] = mezok[5];
            }

            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                for (int j = 0; j < adatok.GetLength(1); j++)
                {
                    Console.Write($"{adatok[i, j]}\t");
                }
                Console.WriteLine();
            }

            int induloMagassag = 192;
            int celMagassag = induloMagassag;

            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                celMagassag += int.Parse(adatok[i, 3]);
                celMagassag -= int.Parse(adatok[i, 4]);
            }

            Console.WriteLine(celMagassag);

            int szakasz = 0;

            for (int i = 0;i < adatok.GetLength(0);i++)
            {
                szakasz++;
            }

            Console.WriteLine($"A szakaszok száma: {szakasz} db");

            double teljeshossz = 0;

            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                teljeshossz += Convert.ToDouble(adatok[i,2]);
            }

            Console.WriteLine($"A túra teljes hossza: {teljeshossz} km");

            int min = 0;

            for (int i = 1; i < adatok.GetLength(0); i++)
            {
                if (double.Parse(adatok[i,2])< double.Parse(adatok[min,2]))
                {
                    min = i;
                }
            }

            Console.WriteLine($"A legrövidebb szakasz adatai:\n Kezdete: {adatok[min, 0]}\n Vége: {adatok[min,1]}\n Távolság: {adatok[min,2]} km");

            int kezdoMagassag = 192;
            int index = 0;
            int MaxMagassag = kezdoMagassag;
            int aktMagassag = MaxMagassag;

           for (int i = 0; i <adatok.GetLength(0); i++)
            {
                aktMagassag = aktMagassag + int.Parse(adatok[i, 3]) - int.Parse(adatok[i,4]);

                if (aktMagassag>MaxMagassag)
                {
                    MaxMagassag = aktMagassag;
                    index = i;
                }
            }

            Console.WriteLine($"A túra legmagasabban fekvő végpontja:\n A végpont neve: {adatok[index,1]}\n A végpont tengerszint feletti magassága: {MaxMagassag} m");

            Console.WriteLine($"Hiányos állomás nevek:");

            for (int i = 0;i < adatok.GetLength(0);i++)
            {
               if (HianyosNev(adatok[i, 1], char.Parse(adatok[i, 5])))
                {
                    Console.WriteLine($"{adatok[i, 1]}");
                }
            }


            StreamWriter writer= new StreamWriter("kektura2.csv");
            writer.WriteLine("192");

            for (int i = 0; i <adatok.GetLength(0);i++)
            {
                string joVegpontNev = adatok[i, 1];

                if(HianyosNev(adatok[i, 1], char.Parse(adatok[i, 5])))
                {
                    joVegpontNev += " pecsetelohely";
                }

                egySor =$"{ adatok[i, 0]};{joVegpontNev};{adatok[i, 1]};{adatok[i, 2]};{adatok[i, 3]};{adatok[i, 4]};{adatok[i, 5]}";
                writer.WriteLine(egySor);
            }


            writer.Close();
          

            Console.ReadKey();
        }
    }
}
