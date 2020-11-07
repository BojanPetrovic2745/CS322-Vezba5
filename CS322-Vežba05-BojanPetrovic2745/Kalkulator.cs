using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Vežba05_BojanPetrovic2745
{
    class Kalkulator : IKalkulator
    {
        double IKalkulator.deli(double a, double b)
        {
            if(b < 0.0)
            {
                
                return 0.0;
            }
            else
            {
                return a / b;
            }
        }

        double IKalkulator.mnozi(double a, double b)
        {
            return a * b;
        }

        double IKalkulator.oduzmi(double a, double b)
        {
            return a - b;
        }

        double IKalkulator.saberi(double a, double b)
        {
            return a + b;
        }
    }
}
