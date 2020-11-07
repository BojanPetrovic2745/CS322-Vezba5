using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Vežba05_BojanPetrovic2745
{
    class Osoba : OsobaAbstract
    {
        public Osoba(string ime): base(ime)
        {
            
        }

        public Osoba(string ime, string prezime, int godine): base(ime,prezime, godine)
        {
            
        }

        public override void PrintOsoba()
        {
            Console.WriteLine("Ime: " + Ime + " Prezime: " + Prezime + " Godine: " + Godine);
        }
    }
}
