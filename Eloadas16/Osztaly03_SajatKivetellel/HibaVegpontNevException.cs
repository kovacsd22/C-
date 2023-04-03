using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly03_SajatKivetellel
{
    internal class HibaVegpontNevException:Exception
    {
        int hibasSorSzama;
        string hibasAdat;

        public int HibasSorSzama
        {
            get { return hibasSorSzama; }
            set { hibasSorSzama = value; }
        }

        public string HibasAdat
        {
            get { return hibasAdat;}
            set { hibasAdat = value;}
        }

        public HibaVegpontNevException(int hibasSorSzama, string hibasAdat)
        {
            HibasSorSzama = hibasSorSzama;
            HibasAdat = hibasAdat;
        }
    }
}
