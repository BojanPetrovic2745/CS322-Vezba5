using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Vežba05_BojanPetrovic2745
{
    class Program
    {
        static void Main(string[] args)
        {

            Osoba o = new Osoba("bojan", "petrovic", 24);
            Osoba o2 = new Osoba("drugo ime");
            IKalkulator k = new Kalkulator();

            o.PrintOsoba();
            o2.PrintOsoba();

            Console.WriteLine(k.saberi(2.0, 3.0));
            Console.WriteLine(k.oduzmi(2.0, 3.0));
            Console.WriteLine(k.mnozi(2.0, 3.0));
            Console.WriteLine(k.deli(2.0, 3.0));

        }
    }
}
