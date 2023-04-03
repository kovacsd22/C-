using System;

namespace Struktura_Struct
{
    internal class Program
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


        static void Main(string[] args)
        {
            Diak diak1 = new Diak();
            diak1.vezetekNev = "Kovács";
            diak1.keresztNev = "Dániel";
            diak1.szuletesiIdo = "2000.09.09";
            diak1.szuletesiHely = "Miskolc";
            diak1.anyjaNeve = "Tóth Anita";
            diak1.oktatasiAzonosito = 71605908050;
            diak1.tajSzam = 589768742;
            diak1.adoSzam = 8569874895;
            diak1.nem = false;
            diak1.tankoteles = 'n';
            diak1.felEviAtlag = 4.5;
            diak1.KiIras();

            Diak diak2 = new Diak();
            diak2.vezetekNev = "Németh";
            diak2.keresztNev = "Ábel";
            diak2.szuletesiIdo = "2002.01.01";
            diak2.szuletesiHely = "Miskolc";
            diak2.anyjaNeve = "Németh Tímea";
            diak2.oktatasiAzonosito = 87596587452;
            diak2.tajSzam = 896745896;
            diak2.adoSzam = 8975698745;
            diak2.nem = false;
            diak2.tankoteles = 'n';
            diak2.felEviAtlag = 1.9;
            Console.WriteLine("------------------");
            diak2.KiIras();

            Diak diak3= new Diak("Ó","Éva","2000.01.01","Mátészalka","Tirpák Ramóna",715879487614,125125125,125489637,true,'n',3.76);
            Console.WriteLine("------------------");
            Console.WriteLine(diak3);
            Console.ReadKey();
        }
    }
}
