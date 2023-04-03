using KivetelKezetes_Struct.Kivételek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KivetelKezetes_Struct
{
    internal class Program
    {
        public class Labda
        {
            private int pottyokSzama;
            private int meret;
            string szin;
            string fajta;
            bool lapose;

            public int PottyokSzama
            {
                get { return pottyokSzama; }
                set { pottyokSzama = value; }
            }

            public override string ToString()
            {
                return $"Fajta: {this.fajta}|Pöttyökszáma: {this.pottyokSzama}|Szine: {this.szin}|Méret:{this.meret}|Lapos-e: {this.lapose}| ";
            }

            public Labda(int pottyokSzama, int meret, string szin, string fajta, bool lapose)
            {
                this.PottyokSzama = pottyokSzama;
                this.meret = meret;
                this.szin = szin;
                this.fajta = fajta;
                this.lapose = lapose;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Labda egyLabda = new Labda(10, 5, "Piros", "Pöttyös", false);

                Console.WriteLine(egyLabda);
                egyLabda.PottyokSzama = 12;

                Console.WriteLine(egyLabda);
            }
            catch(PöttyökSzámaHiba e)
            {
                Console.WriteLine($"Hibás érték: {e.HibasAdat} Hibás fajta: {e.HibasFajta}");
            }

                
            
           
           




            Console.ReadKey();
        }
    }
}
