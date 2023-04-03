using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaListabanTarolva
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Diak diak1 = new Diak("Ó", "Éva", "2000.01.01", "Mátészalka", "Tirpák Ramóna", 71587948761, 125125125, 1254896374, true, 'n', 3.76);
            Diak diak2 = new Diak("K", "Ede", "2000.03.14", "Tiszaújváros", "Alati Alati", 85296374125, 523523523, 8965237412, false, 'i', 2.1);
            Console.WriteLine(diak1);

            List<Diak> diakok = new List<Diak>();
            diakok.Add(diak1);
            diakok.Add(diak2);
            
            foreach (Diak egyDiak in diakok)
            {
                Console.WriteLine("----------------");
                Console.WriteLine(egyDiak);
            }


            //vektor
            Diak[] diaks= new Diak[] { diak1,diak2 };

            //halmaz
            HashSet<Diak> diak = new HashSet<Diak>(); 
            diak.Add(diak1);
            diak.Add(diak2);

            //verem
            Stack<Diak> stack = new Stack<Diak>();
            stack.Push(diak1); stack.Push(diak2 );

            //sor
            Queue<Diak> queue = new Queue<Diak>();
            queue.Enqueue(diak1);
            queue.Enqueue(diak2);

            //szótár
            Dictionary<int,Diak> dict= new Dictionary<int,Diak>();
            dict.Add(1,diak1);
            dict.Add(2,diak2);

            //tuple
            Tuple<Diak>[] stud =
            {
                new Tuple<Diak>(diak1),
                new Tuple<Diak>(diak2)
            };

            //Array

            ArrayList diakokArray = new ArrayList();
            diakokArray.Add(diak1);
            diakokArray.Add(diak2);


            Console.ReadKey();
        }
    }
}
