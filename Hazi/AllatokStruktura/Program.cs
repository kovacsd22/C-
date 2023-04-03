using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokStruktura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Allatok Zsiraf = new Allatok("Emlősök", "Szaharától délre (szavannák)", "Kérődző", "1180 - 1930 kg", "Sebezhető (Sebezhetőnek nevezzük azokat a élőlényfajokat, illetve alfajokat, amelyek kihalási esélye természetes élőhelyén nagy, beavatkozás nélkül nagy valószínűséggel veszélyeztetetté válik.)");
            Allatok BarnaMedve = new Allatok("Emlősök", "Eurázsiai kontinens, Alaszka, USA, Kanada, Mexikó, Atlasz-hegység", "Mindenevő", "80 - 680 kg", "Nem fenyegetett (Nem fenyegetettnek nevezzük azokat a élőlényfajokat, illetve alfajokat, amelyeket nem fenyeget a kihalás veszélye, és ez a közeljövőben sem várható.) !!!!! Magyarországon fokozottan védett !!!!!");
            Allatok Csimpanz = new Allatok("Emlősök", "Guineától Gabonig, Kongói Demokratikus Köztársaság északi felében, Trópusi esőerdőkben és fás szavannákon egyaránt megél.", "Mindenevő", "26 - 120 kg", "Nincs");
            Allatok Sinomacrops = new Allatok("Hüllő", "a mai Daohugou-ágyakból, a Tiaojishan formációból , Mutoudengben, Csinglong megyében , Hebeitartományban", "Rovarevő", "5 kg", "Kihalt");
            Allatok Liger = new Allatok("Emlősök", "leggyakrabban állatkertben (rezervátum is) vagy cirkuszban (Parlament)", "Húsevő", "400 - 800 kg", "Nem tudunk róla, legyengült szervezet");

            //vektor
            Allatok[] allatokVektor = new Allatok[] { Zsiraf, BarnaMedve, Csimpanz, Sinomacrops, Liger };

            //lista
            List<Allatok> allatokLista = new List<Allatok>() { Zsiraf, BarnaMedve, Csimpanz, Sinomacrops, Liger };

            //halmaz
            HashSet<Allatok> allatokHalmaza = new HashSet<Allatok>() { Zsiraf, BarnaMedve, Csimpanz, Sinomacrops, Liger };

            //sor
            Queue<Allatok> allatokSora = new Queue<Allatok>();
            allatokSora.Enqueue(Zsiraf);
            allatokSora.Enqueue(BarnaMedve);
            allatokSora.Enqueue(Csimpanz);
            allatokSora.Enqueue(Sinomacrops);
            allatokSora.Enqueue(Liger);

            //tuple
            Tuple<Allatok>[] allatokTuple =
            {
                new Tuple<Allatok>(Zsiraf),
                new Tuple<Allatok>(BarnaMedve),
                new Tuple<Allatok>(Csimpanz),
                new Tuple<Allatok>(Sinomacrops),
                new Tuple<Allatok>(Liger)
        };

            //szótár
            Dictionary<int, Allatok> allatokSzotar = new Dictionary<int, Allatok>();
            allatokSzotar.Add(1,Zsiraf);
            allatokSzotar.Add(2, BarnaMedve);
            allatokSzotar.Add(3, Csimpanz);
            allatokSzotar.Add(4, Sinomacrops);
            allatokSzotar.Add(5, Liger);

            Console.ReadKey();
        }
    }
}
