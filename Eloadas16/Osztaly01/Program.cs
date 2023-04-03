using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly01
{
    internal class Program
    {
        static List<Record> rekordLista = new List<Record>();
        static void Main(string[] args)
        {
            Record tesztRecord= new Record();
            tesztRecord.kiinduloPont = "Kezdő";
            tesztRecord.vegPont = "Vég";
            tesztRecord.turaSzakaszHossza = 1.567;
            tesztRecord.emelkedes = 100;
            tesztRecord.lejtes= 11;
            tesztRecord.pecseteloHelyE = 'n';

            StreamReader reader = new StreamReader("kektura.csv");

            int induloMagassag = int.Parse(reader.ReadLine());

            while (!reader.EndOfStream)
            {
                string beolvasottsor = reader.ReadLine();
                string[] mezok = beolvasottsor.Split(';');
                Record beolvasottRecord = new Record();
                beolvasottRecord.kiinduloPont = mezok[0];
                beolvasottRecord.vegPont = mezok[1];
                beolvasottRecord.turaSzakaszHossza = double.Parse(mezok[2]);
                beolvasottRecord.emelkedes = int.Parse(mezok[3]);
                beolvasottRecord.lejtes = int.Parse(mezok[4]);
                beolvasottRecord.pecseteloHelyE = char.Parse(mezok[5]);
                rekordLista.Add(beolvasottRecord);
                //beolvasottRecord.pecseteloHelyE = mezok[5][0];
            }

            reader.Close();

            foreach (var item in rekordLista)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
        }
    }
}
