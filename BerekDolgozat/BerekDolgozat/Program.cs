using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BerekDolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("C:\\Users\\Tanulo\\source\\repos\\BerekDolgozat\\BerekDolgozat\\berek2020.txt");

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
            }

            int Dolgozo = 0;

            for (int i = 1; i < adatok.GetLength(0); i++)
            {
                Dolgozo++;
            }

            Console.WriteLine($"Dolgozók száma: {Dolgozo} fő");

            double atlag;
            int berekTeljes = 0;
            int db = 0;

            for (int i = 1; i < adatok.GetLength(0); i++)
            {
                if (mezok[4] != "")
                {
                    berekTeljes += int.Parse(adatok[i,4]);
                    db++;
                }
            }
            atlag = berekTeljes / db;
            double atlag2 = atlag / 1000; 

            Console.WriteLine($"Bérek átlaga: {Math.Round(atlag2,1)} eFt");


            Console.Write("Kérem egy részleg nevét: ");
            string reszlegnev = Console.ReadLine();

            int max = 1;

            for (int i = 2; i < adatok.GetLength(0); i++)
            {
                if (adatok[i,2].Contains(reszlegnev) && (double.Parse(adatok[i, 4]) > double.Parse(adatok[max, 4])))
                {
                    max = i;
                }
                else if (adatok[0,2] != reszlegnev)
                {
                    Console.WriteLine("Ilyen részleg nem létezik a cégnél!")
                }
            }

            Console.WriteLine("A legtöbbet kereső dolgozó a megadott részlegen");
            Console.WriteLine($"Név: {adatok[max,0]}\n Neme: {adatok[max, 1]}\n Belépés: {adatok[max,3]}\n Bér {adatok[max,4]} Forint");




            Console.ReadKey();
        }
    }
}
