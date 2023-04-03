using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromDimenziosTomb
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[] tantargyak = new string[6] { "Programozás alapok", "Hálózat I.", "Hálózatok II.", "IKT Projektmunka", "Munkavállalói ismeretek", "Szakmai Angol" };
            string[] tanulok = { "Tóth V.", "Kiss G.", "Kutasi E.", "Szabó J.", "Kelemen Á.", "Kovács D.", "Juhász B.", "Novák D.", "Dimény S.", "Lenygel B.", "Balázs M.", "Fekete D.", "Várdai B.", "Pejkó B.", "Sándor K.", "Héjjas Gy." };
            string[] szovegesErtekeles = new string[5] { "Elégtelen", "Elégséges", "Közepes", "Jó", "Jeles" };
            int[,,] naplo = new int[6,16,5];//1-tantargy kód, 2-tanuló kód, 3-havi értékelés (1-szeptember.....5-január)

            for (int i = 0; i < naplo.GetLength(0); i++)
            {
                for (int j = 0; j < naplo.GetLength(1); j++)
                {
                    for (int k = 0; k < naplo.GetLength(2); k++)
                    {
                        naplo[i, j, k] = rnd.Next(1, 6);
                    }
                }
            }
            
            foreach (var item in naplo)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            for (int i = 0; i < tanulok.Length; i++)
            {
                for (int j = 0; j < tantargyak.Length; j++)
                {
                    Console.Write($"{tanulok[i]} - {tantargyak[j]}:\t");
                    int feleviJegyekOsszege = 0;
                    for (int k = 0; k < 5; k++)
                    {
                        Console.Write($"{naplo[j,i,k]}\t");
                        feleviJegyekOsszege += naplo[j, i, k];
                    }
                    double atlag = Math.Round((double)feleviJegyekOsszege / 5);
                    Console.WriteLine();
                    Console.WriteLine($"Félévi eredmény: {szovegesErtekeles[(int)atlag-1]}");
                }
                Console.WriteLine();
            }


            
            Console.ReadKey();
        }
    }
}
