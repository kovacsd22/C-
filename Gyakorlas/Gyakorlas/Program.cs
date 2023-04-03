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
            string[,,] t1 = new string[7, 4, 6];

            t1[0, 0, 0] = "Társasjáték:";
            t1[0, 1, 0] = " Ki nevet a végén?";
            t1[0, 2, 0] = " Gazdálkodjk okosan!";
            t1[0, 3, 0] = " Monopoly";

            t1[3, 0, 0] = "RC autók:";
            t1[3, 1, 0] = " elfogyott";
            t1[3, 2, 0] = " verseny";
            t1[3, 3, 0] = " elfogyott";

            t1[4, 0, 0] = "Kártyák:";
            t1[4, 1, 0] = " Francia";
            t1[4, 2, 0] = " Tarot kártya";
            t1[4, 3, 0] = " elfogyott";

            for (int i = 0; i < t1.GetLength(1); i++)
            {
                for(int j = 0; j < t1.GetLength(0);j++)
                {
                    Console.Write($"{t1[j,i,0]} ");
                }
                Console.WriteLine();
            }

            string leghosszabb = "";
            Console.WriteLine(t1.Length);
            foreach (var item in t1)
            {
                if(item != null && item.Length > leghosszabb.Length)
                {
                    leghosszabb = item;
                }
            }
            Console.WriteLine(leghosszabb);

            

            Console.ReadKey();
        }
    }
}
