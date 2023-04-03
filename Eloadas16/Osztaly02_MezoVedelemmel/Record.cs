using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly02_MezoVedelemmel
{
    internal class Record
    {
        string kiinduloPont;
        string vegPont;
        double turaSzakaszHossza;
        int emelkedes;
        int lejtes;
        char pecseteloHelyE;


        public string KiinduloPont
        {
            get { return kiinduloPont; }
            set { kiinduloPont = value; }
        }

        public string VegPont
        {
            get { return vegPont; }
            set {
                    if (PecseteloHelyE == 'i')
                    {
                        if (!value.Contains("pecsetelohely"))
                        {
                            value += "pecsetelohely";
                        }
                        vegPont= value;
                    }
                    else
                    {
                        { vegPont = value; }
                    }
                }
        }

        public double TuraSzakaszHossza
        {
            get { return turaSzakaszHossza; }
            set
            {
                turaSzakaszHossza = value;
            }
        }

        public int Emelkedes
        {
            get { return emelkedes; }
            set
            {
                emelkedes = value;
            }
        }

        public int Lejtes
        {
            get { return lejtes; }
            set
            {
                lejtes = value;
            }
        }

        public char PecseteloHelyE
        {
            get { return pecseteloHelyE; }
            set { pecseteloHelyE = value; }
        }


        public override string ToString()
        {
            return $"K.pont: {kiinduloPont}|V.pont: {vegPont}|Hossz: {turaSzakaszHossza}|Emel: {emelkedes}|Lejt: {lejtes}|Phely: {pecseteloHelyE}";
        }

        public Record(string kiinduloPont, string vegPont, double turaSzakaszHossza, int emelkedes, int lejtes, char pecseteloHelyE)
        {
            PecseteloHelyE = pecseteloHelyE;
            KiinduloPont = kiinduloPont;
            VegPont = vegPont;
            TuraSzakaszHossza = turaSzakaszHossza;
            Emelkedes = emelkedes;
            Lejtes = lejtes;   
        }


        public Record (string beolvasottSor)
        {
            string[] mezok = beolvasottSor.Split(';');
            PecseteloHelyE = char.Parse(mezok[5]);
            KiinduloPont = mezok[0];
            VegPont = mezok[1];
            TuraSzakaszHossza = double.Parse(mezok[2]);
            Emelkedes = int.Parse(mezok[3]);
            Lejtes = int.Parse(mezok[4]); 
        }
    }
}
