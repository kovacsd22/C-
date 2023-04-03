using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KivetelKezetes_Struct.Kivételek
{
    internal class PöttyökSzámaHiba:Exception
    {
        int hibasAdat;
        string hibasFajta;

        public int HibasAdat
        {
            get { return hibasAdat; }

            set { hibasAdat = value; }
        }

        public string HibasFajta
        {
            get { return hibasFajta; }
            set { hibasFajta = value; }
        }

        public PöttyökSzámaHiba(int hibasAdat, string hibasFajta)
        {
            HibasAdat = hibasAdat;
            HibasFajta = hibasFajta;
        }

     
    }
}


