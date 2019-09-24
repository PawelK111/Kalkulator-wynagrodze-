using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wynagrodzenia
{
    class Obciazenia
    {
        public decimal Emerytalna { get; private set; }
        public decimal Rentowa { get; private set; }
        public decimal Chorobowa { get; private set; }
        public decimal Zdrowotna1 { get; private set; }  // ubezpieczenie zdrowotne - skladka nr 1
        public decimal PD { get; private set; } // podatek dochodowy
        public decimal KUP { get; private set; } // koszty uzyskania przychodu
        public decimal Zdrowotna2 { get; private set; } // ubezpieczenie zdrowotne - skladka nr 2
        public decimal KWOP { get; private set; } // Kwota wolna od podatku

        public Obciazenia(decimal emerytalna, decimal rentowa, decimal chorobowa, decimal zdrowotna1, decimal pd, decimal kup, decimal zdrowotna2, decimal kwop)
        {
            Emerytalna = emerytalna;
            Rentowa = rentowa;
            Chorobowa = chorobowa;
            Zdrowotna1 = zdrowotna1;
            PD = pd;
            KUP = kup;
            Zdrowotna2 = zdrowotna2;
            KWOP = kwop;
        }
    }
}
