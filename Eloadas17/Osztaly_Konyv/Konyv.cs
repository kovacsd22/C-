using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Konyv
    {
        string isbnSzam;
        string szerzo_k;
        string muCime;
        int kiadasiEv;
        string nyelv;
        bool enciklopedia; //true / false
        char eBook; // i / n

        public string IsbnSzam
        { get { return isbnSzam; } set { isbnSzam = value; }}

        public string Szerzo_k
        { get { return szerzo_k;} set { szerzo_k = value;} }

        public string MuCime
        { get { return muCime; } set { muCime = value; }}

        public int KiadasiEv
        { get { return kiadasiEv; }set{kiadasiEv = value;} }

        public string Nyelv
        { get { return nyelv;} set { nyelv = value; }}

        public bool Enciklopedia
        { get { return enciklopedia; } set { enciklopedia = value; } }

        public char EBook
        { get { return eBook; } set { eBook = value; }}

        public Konyv(string isbnSzam, string szerzo_k, string muCime, int kiadasiEv, string nyelv, bool enciklopedia, char eBook)
        {
            IsbnSzam = isbnSzam;
            Szerzo_k = szerzo_k;
            MuCime = muCime;
            KiadasiEv = kiadasiEv;
            Nyelv = nyelv;
            Enciklopedia = enciklopedia;
            EBook = eBook;
        }

        public override string ToString()
        {
            return $"A könyv adatai: \n Isbn szám:{isbnSzam}| Szerzője: {szerzo_k}| A mű címe: {muCime}| Kiadásának éve: {kiadasiEv}| Eredeti írott nyelve: {nyelv}| Enciklopédia-e:  {enciklopedia}| Ebook-e: {eBook}.";
        }
        public Konyv()
        {

        }

        ~Konyv()//destruktor <--> konstruktor
        {

        }
    }
}
