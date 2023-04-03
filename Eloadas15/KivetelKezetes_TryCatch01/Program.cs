using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KivetelKezetes_TryCatch01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool joAdat = false;
            int szamlalo = 0;
            while(!joAdat)
            {
 
                try
                {
                    Console.Write("Kérem az elétkorát: ");
                    int eletKor = int.Parse(Console.ReadLine());
                    joAdat = true;
                }
                catch(System.FormatException)
                {
                    if (szamlalo<5)
                    {
                        Console.WriteLine($"Adatbeviteli hiba ({szamlalo+1})");
                    }
                    else
                    {
                        Console.WriteLine("Ennyire.....");
                    }
                }
                catch(System.ApplicationException)
                {
                    Console.WriteLine("Application error!");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                catch
                {
                    Console.WriteLine("Egyéb hiba!");
                }
                finally
                {
                    Console.WriteLine("Ez itt a finally ág!");
                    szamlalo++;
                }
            }

            Console.WriteLine("Vége!");


            Console.ReadKey();
        }
    }
}
