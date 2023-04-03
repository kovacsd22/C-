using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly02_MezoVedelemmel
{
    internal class Program
    {
        static List<Record> adatok = new List<Record>();
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("kektura.csv");
                int induloMagassag = int.Parse(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    adatok.Add(new Record(reader.ReadLine()));
                }

                reader.Close();

                foreach (Record record in adatok)
                {
                    Console.WriteLine(record);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            string kNev = "";
            string vNev = "";
            double tszHossz = 0;
            int emel = 0;
            int lejt = 0;
            char phelye = 'i';

            Console.Write("Kérem a kiindulás nevét: ");
            kNev= Console.ReadLine();
            Console.Write("Kérem a végpont nevét: ");
            vNev= Console.ReadLine();
            do
            {
                Console.Write("Kérem a teljesszakaszhosszát: ");
            } while (!double.TryParse(Console.ReadLine(), out tszHossz));
            do
            {
                Console.Write("Kérem az emelkedés hosszát: ");
            } while (!int.TryParse(Console.ReadLine(), out emel));
            do
            {
                Console.Write("Kérem a lejtés hosszát: ");
            } while (!int.TryParse(Console.ReadLine(), out lejt));
            do
            {
                Console.Write("Kérem hogy van e pecsetélőhelye: (i/n) ");
            } while (!char.TryParse(Console.ReadLine(), out phelye) || (phelye!='i' && phelye!='n'));

            //Console.WriteLine($"Kiindulás: {kNev}|Végpont: {vNev}|Teljesszakaszhassz: {tszHossz}|Emelkedés: {emel}|Lejtés: {lejt}|Pecsételőhely-e: {phelye}");

            Record bevittRecord = new Record(kNev,vNev,tszHossz,emel,lejt,phelye);
            Console.WriteLine(bevittRecord);




            Console.ReadKey(); 
        }
    }
}
