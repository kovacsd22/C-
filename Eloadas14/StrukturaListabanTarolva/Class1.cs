using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaListabanTarolva
{
    
        struct Diak
        {
            public string vezetekNev;
            public string keresztNev;
            public string szuletesiIdo;
            public string szuletesiHely;
            public string anyjaNeve;
            public long oktatasiAzonosito;
            public int tajSzam;
            public long adoSzam;
            public bool nem; //false=férfi, true=nő
            public char tankoteles;// i/n
            public double felEviAtlag;

            public void KiIras()
            {
                Console.WriteLine($"Vezetéknév: {vezetekNev}\n" +
                    $"Keresztnév: {keresztNev}\nSzületési idő: " +
                    $"{szuletesiIdo}\nSzületési hely: {szuletesiHely}\n" +
                    $"Anyja neve: {anyjaNeve}\nOktatási azonosító: " +
                    $"{oktatasiAzonosito}\nTajszám: " +
                    $"{tajSzam.ToString().Substring(0, 3)} "
                    + $"{tajSzam.ToString().Substring(3, 3)} " +
                    $"{tajSzam.ToString().Substring(6, 3)}\nAdószám: " +
                    $"{adoSzam}\nNeme: {(nem ? "Nő" : "Férfi")}\n" +
                    $"Tanköteles-e: {(tankoteles == 'i' ? "Igen" : "Nem")}" +
                    $"\nFélévi átlaga: {felEviAtlag}");
            }

            public override string ToString()
            {
                return $"Vezetéknév: {vezetekNev}\nKeresztnév: {keresztNev}" +
                    $"\nSzületési idő: {szuletesiIdo}\nSzületési hely: " +
                    $"{szuletesiHely}\nAnyja neve: {anyjaNeve}\n" +
                    $"Oktatási azonosító: {oktatasiAzonosito}\n" +
                    $"Tajszám: {tajSzam.ToString().Substring(0, 3)} "
                    + $"{tajSzam.ToString().Substring(3, 3)} " +
                    $"{tajSzam.ToString().Substring(6, 3)}\n" +
                    $"Adószám: {adoSzam}\nNeme: {(nem ? "Nő" : "Férfi")}\n" +
                    $"Tanköteles-e: {(tankoteles == 'i' ? "Igen" : "Nem")}\n" +
                    $"Félévi átlaga: {felEviAtlag}";
            }
        public Diak(string vezetekNev, string keresztNev, string szuletesiIdo, string szuletesiHely, string anyjaNeve, long oktatasiAzonosito, int tajSzam, long adoSzam, bool nem, char tankoteles, double felEviAtlag)
        {
            this.vezetekNev = vezetekNev;
            this.keresztNev = keresztNev;
            this.szuletesiIdo = szuletesiIdo;
            this.szuletesiHely = szuletesiHely;
            this.anyjaNeve = anyjaNeve;
            this.oktatasiAzonosito = oktatasiAzonosito;
            this.tajSzam = tajSzam;
            this.adoSzam = adoSzam;
            this.nem = nem;
            this.tankoteles = tankoteles;
            this.felEviAtlag = felEviAtlag;
        }
    }

    }

