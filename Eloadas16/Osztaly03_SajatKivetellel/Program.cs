using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly03_SajatKivetellel
{
    internal class Program
    {
        static List<Record> adatok = new List<Record>();
        public static int beolvasottSorSzama = 2;
        static void Main(string[] args)
        {
            List<string> hibasAdatok = new List<string>();
            try
            {
                StreamReader reader = new StreamReader("kektura.csv");
                int induloMagassag = int.Parse(reader.ReadLine());
                
                while (!reader.EndOfStream)
                {
                    try
                    {
                        adatok.Add(new Record(reader.ReadLine()));
                       
                    }
                    catch (HibaVegpontNevException e)
                    {
                        hibasAdatok.Add($"Hibás sor száma: {e.HibasSorSzama} Hibás adat: {e.HibasAdat}");
                    }
                    finally
                    { 
                        beolvasottSorSzama++;
                    }
                    
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
                
            }
            Console.WriteLine(hibasAdatok.Count);

            File.AppendAllLines("hibasAdatok.txt", hibasAdatok);

            using (StreamWriter hibasAdatok2 = new StreamWriter("hibasadatok2.txt"))
            {
                foreach (var item in hibasAdatok)
                {
                   hibasAdatok2.WriteLine(item);
                }
            }


            Console.ReadKey();
        }
    }
}
