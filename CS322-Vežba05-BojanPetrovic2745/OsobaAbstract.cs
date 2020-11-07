using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Vežba05_BojanPetrovic2745
{
    abstract class OsobaAbstract
    {

        private string ime;
        private string prezime;
        private int godine;

        public string Ime
        {
            get { return ime; }
            protected set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            protected set { prezime = value; }
        }

        public int Godine
        {
            get { return godine; }
            protected set { godine = value; }
        }

        public OsobaAbstract(string ime)
        {
            Ime = ime;
        }

        public OsobaAbstract(string ime, string prezime, int godine)
        {
            Ime = ime;
            Prezime = prezime;
            Godine = godine;
        }

        public abstract void PrintOsoba();
    }
}
