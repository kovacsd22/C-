using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombIsmetles
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[,] tomb = new int[20,30];
            Dictionary<string,int> keyValuePairs= new Dictionary<string,int>
            { 
                {"1000 alatti",0},
                {"1000 - 2000 közötti",0},
                {"2000 feletti",0}
            };

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    int veletlen = rnd.Next(800, 2500);
                    tomb[i,j] = veletlen;
                    while (veletlen % 13 == 0)
                    {
                        veletlen = rnd.Next(800, 2500);
                    }
                    Console.Write($"{tomb[i, j]}\t");

                    if (veletlen < 1000)
                    {
                        keyValuePairs["1000 alatti"]++;
                    }
                    if (veletlen > 1000 && veletlen < 2000)
                    {
                        keyValuePairs["1000 - 2000 közötti"]++;
                    }
                    if (veletlen > 2000)
                    {
                        keyValuePairs["2000 feletti"]++;
                    }
                }
            }
            Console.WriteLine(" ");
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}: { item.Value}");
            }

            Console.ReadKey();
        }
    }
}
