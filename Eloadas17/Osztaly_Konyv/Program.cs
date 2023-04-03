using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    
    internal class Program
    {
        public static void IsbnValiditas(string isbn)
        {
            /*if (isbn == null || (isbn.Length != 10 && isbn.Length != 13))
            {
                throw new ArgumentException("Nem megfelelő ISBN formátum.");
            }*/

            var szamok = isbn.Replace("-", "").ToCharArray();
            if (szamok.Length == 10)
            {
                int osszeg = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (!char.IsDigit(szamok[i]))
                    {
                        throw new ArgumentException("Nem megfelelő ISBN formátum.");
                    }

                    osszeg += (i + 1) * (int)char.GetNumericValue(szamok[i]);
                }

                char utolsoKarakter = szamok[9];
                if (utolsoKarakter == 'X')
                {
                    osszeg += 10;
                }
                else if (!char.IsDigit(utolsoKarakter))
                {
                    throw new ArgumentException("Nem megfelelő ISBN formátum.");
                }
                else
                {
                    osszeg += 10 * (int)char.GetNumericValue(utolsoKarakter);
                }

                if (osszeg % 11 != 0)
                {
                    throw new ArgumentException("Nem megfelelő ISBN formátum.");
                }
            }
            else if (szamok.Length == 13)
            {
                int osszeg = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (!char.IsDigit(szamok[i]))
                    {
                        throw new ArgumentException("Nem megfelelő ISBN formátum.");
                    }

                    osszeg += (i % 2 == 0) ? (int)char.GetNumericValue(szamok[i]) : 3 * (int)char.GetNumericValue(szamok[i]);
                }

                char utolsoKarakter = szamok[12];
                if (!char.IsDigit(utolsoKarakter))
                {
                    throw new ArgumentException("Nem megfelelő ISBN formátum.");
                }

                if ((10 - osszeg % 10) % 10 != (int)char.GetNumericValue(utolsoKarakter))
                {
                    throw new ArgumentException("Nem megfelelő ISBN formátum.");
                }
            }
            else
            {
                throw new ArgumentException("Nem megfelelő ISBN formátum.");
            }
        }

        static List<Konyv> adatok = new List<Konyv>();

        static void Main(string[] args)
        {
            //Konyv osztaly
            //isbnSzam
            //szerzo_k
            //muCime
            //kiadasiEv
            //nyelv
            //enciklopedia - bool
            //eBook - char i/n


            string isbnSzam = "";
            string szerzo_k = "";
            string muCime = "";
            int kiadasiEv = 0;
            string nyelv = "";
            bool enciklopedia = true;
            char eBook = 'i';



            try
            {
                Console.Write("Kérem a könyv ISBN számát: ");
                isbnSzam = Console.ReadLine();
                IsbnValiditas(isbnSzam);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }



            Console.Write("Kérem a könyv szerzőjének nevét: ");
            szerzo_k = Console.ReadLine();

            Console.Write("Kérem a könyv címét: ");
            muCime = Console.ReadLine();

            do
            {
                Console.Write("Kérem a könyv kiadásának évét: ");
            } while (!int.TryParse(Console.ReadLine(), out kiadasiEv));

            Console.Write("Kérem a könyv íródásának nyelvét: ");
            nyelv = Console.ReadLine();

            do
            {
                Console.Write("Kérem adja meg, hogy a könyv enciklopédia-e: ");
            } while (!bool.TryParse(Console.ReadLine(), out enciklopedia));

           
            do
            {
                Console.Write("A könyv eBook-e: ");

            } while (!char.TryParse(Console.ReadLine(), out eBook) || (eBook != 'i' && eBook != 'n'));
           
    

            Konyv ujKonyv = new Konyv(isbnSzam,szerzo_k,muCime,kiadasiEv,nyelv,enciklopedia,eBook);

            for (int i = 0;i < 10000; i++) 
            {
                Konyv ujKonyv2 = new Konyv(isbnSzam, szerzo_k, muCime, kiadasiEv, nyelv, enciklopedia, eBook);

            }
            Console.WriteLine();
            Console.WriteLine(ujKonyv);
            Console.ReadKey();

        }
    }
}
