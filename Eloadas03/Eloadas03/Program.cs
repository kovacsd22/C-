using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloadas03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string honap;
            Console.Write("Kérem a hónap számát: ");
            byte honapSzama = byte.Parse(Console.ReadLine());
            if (honapSzama == 1)
            {
                honap = "Január";
            }
            else
            {
                if (honapSzama == 2)
                {
                    honap = "Február";
                }
                else
                {
                    if (honapSzama == 3)
                    {
                        honap = "Március";
                    }
                    else
                    {
                        if (honapSzama == 4)
                        {
                            honap = "Április";
                        }
                        else
                        {
                            if (honapSzama == 5)
                            {
                                honap = "Május";
                            }
                            else
                            {
                                if (honapSzama == 6)
                                {
                                    honap = "Június";
                                }
                                else
                                {
                                    if (honapSzama == 7)
                                    {
                                        honap = "Július";
                                    }
                                    else
                                    {
                                        if (honapSzama == 8)
                                        {
                                            honap = "Augusztus";
                                        }
                                        else
                                        {
                                            if (honapSzama == 9)
                                            {
                                                honap = "Szeptember";
                                            }
                                            else
                                            {
                                                if (honapSzama == 10)
                                                {
                                                    honap = "Október";
                                                }
                                                else
                                                {
                                                    if (honapSzama == 11)
                                                    {
                                                        honap = "November";
                                                    }
                                                    else
                                                    {
                                                        if (honapSzama == 12)
                                                        {
                                                            honap = "December";
                                                        }
                                                        else
                                                        {
                                                            honap = "Hibás hónapszámot adott meg.";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(honap);

            Console.ReadKey();
        }
    }
}
