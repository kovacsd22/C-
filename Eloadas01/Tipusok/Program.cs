using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Egész számok típusai
            byte szam1 = 0;// 8 bite 1 byte előjel nélküli 0-255
            byte szam2;
            sbyte szam3 = -128;// 8 bites 1 byte előjeles -128 - +127
            short szam4 = -12122;// 16 bites 2 byte előjeles -32768 - +32767
            ushort szam5 = 11212;// 16 bites 2 byte előjeles 0 - +65535
            int szam6 = -232323222;// 32 bites 4 byte előjeles
            uint szam7 = 632323233;// 32 bites 4 byte előjel nélküli
            long szam8 = -232323232333333333;// 64 bites 8 byte előjeles
            ulong szam9 = 223123123223123121;// 64 bites 8 byte előjel nélküli

            //Valós számok típusai
            float szam10 = 23232.3f;// 32 bites valós szám (előjeles)
            double szam11 = 83828344334.4343434;// 64 bites valós szám (előjeles)
            decimal szam12 = 21212;// 128 bites valós szám (előjeles)
            decimal szam13 = 121212.1212m;// 128 bites valós szám (előjeles)

            //Karakteres változó - kötelezően 1 karakter hosszú!
            char karakter1;
            char karakter2 = 'o';

            //Szöveges változó
            string szoveg1;
            string szoveg2 = "";
            string szoveg3 = "Hello World!";

            //Logikai változó
            bool logiakai1;
            bool logiakai2 = false;
            bool logiakai3 = true;
        }
    }
}
