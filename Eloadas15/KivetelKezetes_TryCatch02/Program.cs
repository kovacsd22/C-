using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace KivetelKezetes_TryCatch02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           

            try
            {
                StreamReader reader = new StreamReader("input.txt");
                reader.Close();
            }
            catch(System.IO.FileNotFoundException) {
                Console.WriteLine("Először kellene egy fájl is!");
            }
            finally
            {
                Console.WriteLine("A program hiba nélkül lefutott!");
            }

            

            Console.ReadKey();
        }
    }
}
