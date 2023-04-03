using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Osztaly01
{
    public class Record
    {
        public string kiinduloPont;
        public string vegPont;
        public double turaSzakaszHossza;
        public int emelkedes;
        public int lejtes;
        public char pecseteloHelyE;


        public override string ToString()
        {
            return $"K.pont: {kiinduloPont}|V.pont: {vegPont}|Hossz: {turaSzakaszHossza}|Emel: {emelkedes}|Lejt: {lejtes}|Phely: {pecseteloHelyE}";
        }

        public Record()
        {

        }
    }
}
