using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool vege = false;
            //int a = int.Parse(Console.Readline());
            int id = 0;
            /*while (!vege)
            {
                Console.Write("Adj meg egy számot: ");
                int.TryParse(Console.ReadLine(), out id);
            }*/
            do 
            {
                Console.Write("Adj meg egy számot: ");
            } while (!int.TryParse(Console.ReadLine(), out id));    
            
            Console.WriteLine(id);

            int eletkor = 18;


            bool rosszErtek = true;
            long darab = 0;
            do
            {
                try

                {
                    Console.Write("Kérem az életkorát: ");
                    eletkor = int.Parse(Console.ReadLine());
                    rosszErtek = false;
                }

                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message);
                    darab++;
                } 
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                    darab++;
                }
                catch
                {
                    //Ugyanaz mint az Exception e (csak az egyikre van szükség)
                    Console.WriteLine("Valamilyen hiba!");
                    darab++;
                }

                finally
                {
                    Console.WriteLine($"Elcseszések száma: {darab}");
                }
            }
            while (rosszErtek);
            
            
            
            







            Console.ReadKey();
        }
    }
}
