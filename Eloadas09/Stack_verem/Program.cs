using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_verem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Diakok=new Stack<string>();

            Diakok.Push("Viktor");
            Diakok.Push("Gergő");
            Diakok.Push("Erzsébet");
            Diakok.Push("Judit");
            Diakok.Push("Ádám");
            Diakok.Push("Balázs");
            Diakok.Push("Dániel");
            Diakok.Push("Dominik");
            foreach (var item in Diakok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Diakok.Count);
            Console.WriteLine(Diakok.Peek());
            int max = Diakok.Count;
            for(int i = 0;i < max; i++)
            {
                Console.WriteLine(Diakok.Pop());
            }


            Console.WriteLine(Diakok.Count);
            Console.ReadKey();
        }
    }
}
