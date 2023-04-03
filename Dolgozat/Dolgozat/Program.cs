using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace Dolgozat
{
    public struct Orszagok
    {
        public string telepules;
        public int idopont;
        public string szeliranyeserosseg;
        public int homerseklet;

        public Orszagok(string telepules, int idopont, string szeliranyeserosseg, int homerseklet)
        {
            this.telepules = telepules;
            this.idopont = idopont;
            this.szeliranyeserosseg = szeliranyeserosseg;
            this.homerseklet = homerseklet;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var orszag = new List<Orszagok>();
            string egySor;
            StreamReader file = new StreamReader("C:\\Users\\Tanulo\\source\\repos\\Dolgozat\\Dolgozat\\tavirathu13.txt");
            var item = new Orszagok();
            int id = 0;


            while ((egySor = file.ReadLine()) != null)
            {
                id++;
                switch (id)
                {
                    case 1: item.telepules = egySor; break;
                    case 2: item.idopont = int.Parse(egySor); break;
                    case 3: item.szeliranyeserosseg = egySor; break;
                    case 4: item.homerseklet = int.Parse(egySor); break;
                }
                if (egySor == "" && id > 0)
                {
                    orszag.Add(item);
                    id = 0;
                    item = new Orszagok();
                }
             
            }

            Queue<Orszagok> orszagresz = new Queue<Orszagok>();
            orszagresz.Enqueue(item);
            Console.ReadKey();
        }
    }
}
