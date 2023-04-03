using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatMatrixSzotart
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[,] nevek = new string[10,2];
            nevek[1, 0] = "Balázs";
            nevek[2, 0] = "Gergő";
            nevek[3, 0] = "Imre";
            nevek[4, 0] = "László";
            nevek[5, 0] = "Bálint";
            nevek[6, 0] = "Barnabás";
            nevek[7, 0] = "Zalán";
            nevek[8, 0] = "Dániel";
            nevek[9, 0] = "Zoltán";
            nevek[10, 0] = "Lívia";

            int[] szamok = new int[rnd.Next(1,6)];
            nevek[1, 1] = szamok.ToString();
            nevek[2, 1] = szamok.ToString();
            nevek[3, 1] = szamok.ToString();
            nevek[4, 1] = szamok.ToString();
            nevek[5, 1] = szamok.ToString();
            nevek[6, 1] = szamok.ToString();
            nevek[7, 1] = szamok.ToString();
            nevek[8, 1] = szamok.ToString();
            nevek[9, 1] = szamok.ToString();
            nevek[10, 1] = szamok.ToString();


        }
    }
}
