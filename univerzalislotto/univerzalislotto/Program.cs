using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace univerzalislotto
{
    internal class Program
    {
        static Random rnd = new Random();
        static void lotto(HashSet<int>szamok)
        {
            int szam = 5; //kézi változtatás
            switch (szam)
            {
                case 5:
                    while (szamok.Count < 5)
                    {
                        szamok.Add(rnd.Next(1, 91));
                        
                    }
                    break;
                case 6:
                    while (szamok.Count < 6)
                    {
                        szamok.Add(rnd.Next(1, 46));
                        
                    }
                    break;
                case 7:
                    while (szamok.Count < 7)
                    {
                        szamok.Add(rnd.Next(1, 36));
                        
                    }
                    break;
                default:
                    break;
            }
           
        }
        static void kiiras(HashSet<int>szamok)
        {
            Console.WriteLine("Lottó számai: ");
            for (int i =1;i <= szamok.Count; i++)
            {
                Console.Write(szamok.ElementAt(i-1));
                if (i < szamok.Count)
                {
                    Console.Write(", ");
                }
            }
            
        }
        static void Main(string[] args)
        {
            HashSet<int> gepiszamok = new HashSet<int>();
            lotto(gepiszamok);
            kiiras(gepiszamok);

            Console.ReadKey();
        }
    }
}
