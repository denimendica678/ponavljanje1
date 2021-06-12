using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje1
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaG objekt = new KlasaG();

            int zbroj = 10, broj = 10;

            objekt.Plus10(zbroj);
            objekt.f50(zbroj);


            Console.ReadKey();
        }
    }
}
