using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorbarendezes
{
    internal class Program
    {
        static Random rnd= new Random();
        static void Main(string[] args)
        {
            //8 ember legyen eltárolva egy veremben 
            // egy "halmazban"-ban ugyanolyan elemszámú mint a verem, véletlenszám generálással (1-elemszámig) intervallumban tároljanak el értékeket
            // a "sor"-ban abban a sorrendben legyenek eltárolva  diákok nevei, ahogy a halmaz-verem párosok meghatározzák.
            // egy szótárban kell visszaadni az adatokat
            string[] diakok = { "Soma", "Gyula", "Balázs", "Dániel", "Kristóf", "Bálint", "Bálint", "Nem tudom" };
            Stack<string> nevek8 = new Stack<string>(diakok);
           
            HashSet<int> sorszam = new HashSet<int>();
            while (sorszam.Count < nevek8.Count)
            {
               sorszam.Add(rnd.Next(1,nevek8.Count+1));
            }
            int z = 0;
            int[] sorSzamok = new int[sorszam.Count];
            foreach(var item in sorszam)
            {
                sorSzamok[z] = item;
                z++;
            }
            Dictionary<int,string> csoport = new Dictionary<int,string>();
            for (int i = 0; i < sorSzamok.Count();i++) 
            {
                csoport.Add(sorSzamok[i],nevek8.Pop());
            }

            Queue<string> diakok2 = new Queue<string>();
            for (int j = 0;j < sorszam.Count();j++) 
            {
                diakok2.Enqueue(csoport[j+1]);
            }
            foreach (var item in diakok2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
