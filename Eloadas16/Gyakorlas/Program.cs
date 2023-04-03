using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sormennyiseg = 0;

            do
            {
                Console.Write("Hány sört ittam meg a hétvégén? (1-10) ");
            } while (!int.TryParse(Console.ReadLine(), out sormennyiseg) || sormennyiseg >10 || sormennyiseg<1);

            if (sormennyiseg == 0)
            {
                Console.WriteLine("Egyáltalán inni jöttél ide haver?!");
            }

            else if (sormennyiseg <=1 && sormennyiseg>= 10)
            {
                Console.WriteLine("Nem megfelelő számot adtál meg!");
            }

            Console.WriteLine($"Ennyi sört ittam ma: {sormennyiseg}");

            int rosszertek = 0;
            
            
                do
                {

                        try
                        {
                            Console.Write("Hány sört ittam meg a hétvégén? (1-10) ");
                            sormennyiseg = int.Parse(Console.ReadLine());
                            rosszertek++;
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine(e.Message);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                        }
                        finally
                        {
                            Console.WriteLine($"Megitt sörök száma: {sormennyiseg}");
                            Console.WriteLine("Szerintem igyál még egy kicsit.");
                        }
                } while (rosszertek>=1 && rosszertek>11);

            switch (sormennyiseg)
            {
                case 1:
                    if (sormennyiseg==1 && sormennyiseg<4)
                    {
                        Console.WriteLine("Jól éreztem magam!"); 
                    }
                    break;
                case 2:
                    if (sormennyiseg > 3 && sormennyiseg < 7)
                    {
                        Console.WriteLine("táncoltma is, de nem tom kivel");
                    }
                    break;
                case 3:
                    if (sormennyiseg >=7 && sormennyiseg < 10)
                    {
                        Console.WriteLine("estek ám ki időszakok");
                    }
                    break; 
                case 4:
                    if (sormennyiseg == 10)
                    {
                        Console.WriteLine("dimenzió kapu nyílás");
                    }
                    break;
                default:
                    Console.WriteLine("Igyál még tesvírem!");
                    break;
            }









            Console.ReadKey();
        }
    }
}
