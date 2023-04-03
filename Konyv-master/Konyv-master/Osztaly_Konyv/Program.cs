using Microsoft.SqlServer.Server;
using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Konyv k = new Konyv();
            /*bool helyes = false;
            do
            {

                Console.Write("Add meg az ISBN számot: ");
                try
                {
                    string bekert = Console.ReadLine();
                    string nums = "";
                    foreach (var item in bekert.Split('-'))
                    {
                        nums += item;
                    }
                    k.IsbnSzam = nums;
                    Console.WriteLine("A megadott ISBN kód helyes! A program kilép...");
                    helyes = true;
                }
                catch (ISBN_NumberLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberFormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!helyes);*/

           
            Konyvespolc konyvesPolc1 = new Konyvespolc();
            try
            {
                Konyv konyv1 = new Konyv("978-963-07-8492-4", "Stephen King", "Az", 1986, "Angol", false, 'n');
                Konyv konyv2 = new Konyv("978-963-07-8492-4", "Stephen King", "Az", 2008, "Magyar", false, 'n');
                konyvesPolc1.konyvHozzaAdasa(konyv1);
                konyvesPolc1.konyvHozzaAdasa(konyv2);
            }
            catch (ISBN_NumberLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ISBN_NumberFormatException e)
            {
                Console.WriteLine(e.Message);
            }

            int db = konyvesPolc1.konyvekSzama;
            Console.WriteLine(db);
            Console.WriteLine(konyvesPolc1.konyvekSzama);
            Console.WriteLine(konyvesPolc1.konyvekSzamaFuggveny());
            Console.ReadKey();
        }
    }
}
