using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operátorok
            //= - értékadó operátor
            byte szam1 = 13;
            byte szam2 = 33;

            //+ - műveleti operátor összeadás
            //- - műveleti operátor kivonás
            //* - műveleti operátor szorzás
            byte szam3 = (byte)(szam1 + szam2);
            Console.WriteLine(szam3);
            int szam4 = int.MaxValue;
            Console.WriteLine(szam4);
            int szam5 = 1;
            long szam6 = (long)szam4 + szam5;
            Console.WriteLine(szam6);
            // / - műveleti operátor osztás
            int szam7 = 10;
            int szam8 = 3;
            Console.WriteLine((double)szam7 / szam8);

            //div képzés (python // operátor) egész osztással érhető el
            double szam9 = 15;
            double szam10 = 9;
            Console.WriteLine((int)szam9 / (int)szam10);

            //% - mod maradék képzés
            Console.WriteLine(szam7 % szam8);
            Console.WriteLine(szam9 % szam10);

            //összehasonlító operátorok
            //<, >, <=, >=, ==, !=

            if (szam8 > 0) //if - egyszerű egyirányú elágazás
            {
                Console.WriteLine("Nagyobb a 3 a 0-nál.");
            }

            //logiakai operátorok
            //&& - és (and) /\
            if (szam8 > 0 && szam9 > 0)
            {
                Console.WriteLine("Mindkét szám nagyobb, mint 0.");
            }

            //|| - vagy (or) \/
            if (szam8 < 0 || szam9 >0)
            {
                Console.WriteLine("Az egyik szám vizsgálata megfelelt.");
            }

            //! - tagadás (not)
            bool igaz = true;
            Console.WriteLine(!igaz);

            //érték változtató operátorok
            //++ - +1
            int a = 0;
            a++;
            Console.WriteLine(a);
            //-- - -1
            a--;
            Console.WriteLine(a);
            //+= 
            a += 4;
            Console.WriteLine(a);
            //-=
            a -= 2;
            Console.WriteLine(a);

            //bitműveleti operátorok
            int sz1 = 128;
            int sz2 = 1;
            //& bitenkénti és
            Console.WriteLine(sz1 & sz2);
            //| bitenkénti vagy
            Console.WriteLine(sz1 | sz2);
            //^ bitenkénti kizáró vagy XOR
            Console.WriteLine(sz1 ^ sz2);
            //<< short left
            Console.WriteLine(sz2<<2);
            //>> short right
            Console.WriteLine(sz1>>2);

            Console.ReadKey();
        }
    }
}
