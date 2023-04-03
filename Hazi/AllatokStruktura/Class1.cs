using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokStruktura
{
    struct Allatok
    {
        public string Osztaly;
        public string Elohely;
        public string Etrend;
        public string Tomeg;
        public string TermeszetvedelmiStatusz;

        public void KiIras()
        {
            Console.WriteLine($"Az állat osztálya: {Osztaly}\nElőhelye: {Elohely}\nÉtrendje: {Etrend}\nTömege: {Tomeg} között változó\nTermészetvédelmi státusza: {TermeszetvedelmiStatusz}");
        }

        public override string ToString()
        {
            return $"Az állat osztálya: {Osztaly}\nElőhelye: {Elohely}\nÉtrendje: {Etrend}\nTömege: {Tomeg} között változó\nTermészetvédelmi státusza: {TermeszetvedelmiStatusz}";
        }

        public Allatok(string osztaly, string elohely, string etrend, string tomeg, string termeszetvedelmiStatusz)
        {
            Osztaly = osztaly;
            Elohely = elohely;
            Etrend = etrend;
            Tomeg = tomeg;
            TermeszetvedelmiStatusz = termeszetvedelmiStatusz;
        }
    }
}
