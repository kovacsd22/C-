using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veletlenszam_verem
{
    internal class Program
    {
        static Random rnd = new Random();


        static void Main(string[] args)
        {
            Stack<int> veletlenszamok = new Stack<int>();

            for (int i = 0; i < 30; i++)
            {
                veletlenszamok.Push(rnd.Next(20, 36));
            }

            Console.WriteLine("Eredeti verem:");
            foreach (int szam in veletlenszamok)
            {
                Console.Write(szam + " ");
            }

            Console.WriteLine();
            Stack<int> forditottVerem = new Stack<int>();
            while (veletlenszamok.Count > 0)
            {
                int szam = veletlenszamok.Pop();
                forditottVerem.Push(szam);
            }

            Console.WriteLine("Fordított verem:");
            foreach (int szam in forditottVerem)
            {
                Console.WriteLine(szam + " ");
            }

            Console.ReadKey();
        }
    }
}
