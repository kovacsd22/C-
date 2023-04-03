using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuq_sor
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Queue<int> szamok = new Queue<int>();
            
            for (int i = 0;i< 15;i++)
            {
                szamok.Enqueue(rnd.Next());
            }
            Console.WriteLine(szamok.Count);
            int elemekSzama = szamok.Count;
            for (int i = 0;i < elemekSzama;i++)
            {
                Console.WriteLine(szamok.Dequeue());
            }



            Console.ReadKey();
        }
    }
}
