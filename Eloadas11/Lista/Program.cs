using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<int> veletlenSzamokListaja = new List<int>();

            for (int i = 0; i < 20;i++)
            {
                veletlenSzamokListaja.Add(rnd.Next());
            }
            Console.WriteLine(veletlenSzamokListaja[14]);
            Console.WriteLine(veletlenSzamokListaja.Count);
            veletlenSzamokListaja.Clear();
            Console.WriteLine(veletlenSzamokListaja.Count);



            List<string> Diakok = new List<string>() {"Judit","Erzsi","Gergő","Viktor","Dominik","Dániel","Balázs","Ádám","Dániel","Máté","Soma","Bálint","Balázs","Gyula","Bálint"};


            Console.WriteLine(Diakok.Count);

            Console.ReadKey();
        }
    }
}
