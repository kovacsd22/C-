using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string honap;
            Console.Write("Kérem a hónap számát: ");
            byte honapSzama = byte.Parse(Console.ReadLine());

            switch (honapSzama)
            {
                case 1:
                    {
                        honap = "Január";
                        break;
                    }
                case 2:
                    {
                        honap = "Február";
                        break;
                    }
                case 3:
                    {
                        honap = "Március";
                        break;
                    }
                case 4:
                    {
                        honap = "Április";
                        break;
                    }
                case 5:
                    {
                        honap = "Május";
                        break;
                    }
                case 6:
                    {
                        honap = "Június";
                        break;
                    }
                case 7:
                    {
                        honap = "Július";
                        break;
                    }
                case 8:
                    {
                        honap = "Augusztus";
                        break;
                    }
                case 9:
                    {
                        honap = "Szeptember";
                        break;
                    }
                case 10:
                    {
                        honap = "Október";
                        break;
                    }
                case 11:
                    {
                        honap = "November";
                        break;
                    }
                case 12:
                    {
                        honap = "December";
                        break;
                    }
                default:
                    {
                        honap = "Hibás hónapszámot adott meg.";
                        break;
                    }
            }

            Console.WriteLine(honap);

            Console.WriteLine();

            bool k = false;
            while (!k)
            {
                Console.WriteLine("Válasszon egy menüpontot:");
                Console.WriteLine("a-téglalap kerülete a és b oldalt kérjék be\r\n" +
                    "b-téglalap területe a és b oldalt kérjék be\r\n" +
                    "c-kör kerülete az átmérőt kérjék be\r\n" +
                    "d-kör területe a sugarat kérjék be\r\nk-kilépés");
                char feladat = char.Parse(Console.ReadLine());
                switch (feladat)
                {
                    case 'a':
                        {
                            Console.Write("Adja meg az a oldalt: ");
                            double a = int.Parse(Console.ReadLine());
                            Console.Write("Adja meg a b oldalt: ");
                            double b = int.Parse(Console.ReadLine());
                            Console.WriteLine("A téglalap kerülete: " + 2 * (a + b));
                            break;
                        }
                    case 'b':
                        {
                            Console.Write("Adja meg az a oldalt: ");
                            double a = int.Parse(Console.ReadLine());
                            Console.Write("Adja meg a b oldalt: ");
                            double b = int.Parse(Console.ReadLine());
                            Console.WriteLine("A téglalap területe: " + (a * b));
                            break;
                        }
                    case 'c':
                        {
                            Console.Write("Adja meg az átmérőt: ");
                            double a = int.Parse(Console.ReadLine());
                            Console.WriteLine("A kör kerülete: " + 2 * a * 3.14);
                            break;
                        }
                    case 'd':
                        {
                            Console.Write("Adja meg a sugarat: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine("A téglalap területe: " + (a * a) * 3.14);
                            break;
                        }
                    case 'k':
                        {
                            k = true;
                            break;
                        }
                }
            }

            Console.ReadKey();
        }
    }
}
