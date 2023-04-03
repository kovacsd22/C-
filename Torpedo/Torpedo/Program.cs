using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    internal class Program
    {
        const int x = 10;
        const int y = 10;
        const int hajokSzama = 5;
        static Random rnd = new Random();

        static bool kornyezetVizsgalasa(int[,] terkep,int x,int y)
        {
            for (int i = 0; i < 3; i++)
            {
                int koordinataY = y + i - 1;
                for (int j = 0; j < 3; j++)
                {
                    int koordinataX = x+j - 1;
                    if (koordinataX > 0 && koordinataY > 0 && koordinataX < Program.x && koordinataY < Program.y)
                    {
                        if (terkep[koordinataX, koordinataY] != 0) 
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] csatater = new int[x,y];
            int[,] csataterTmP = (int[,])csatater.Clone();
            
            for (int i = hajokSzama; i > 0;)
            {
                int X = rnd.Next(0,x);
                int Y = rnd.Next(0,y);
                if (kornyezetVizsgalasa(csatater,X,Y))
                {
                    csataterTmP[X,Y] = i;
                    i--;
                }
            }
            for (int i = 0;i < y;i++)
            {
                for (int j = 0; j< x; j++)
                {
                    Console.Write(csatater[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
