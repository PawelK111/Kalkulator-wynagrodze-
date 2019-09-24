using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wynagrodzenia
{
    public class Wynagrodzenie
    {
        public int Liczba_porzad { get; private set; }
        public decimal Placa_podstawowa { get; set; }
        public decimal Dodatki { get; set; }
        public decimal Wynagr_brutto { get; set; }
        public decimal Ubezp_emerytalne { get; set; }

        public decimal Ubezp_rentowe { get; set; }
        public decimal Ubezp_chorobowe { get; set; }
        public decimal Ubezp_zdrowotne { get; set; }
        public decimal PodatekUS { get; set; }
        public decimal Wynagr_netto { get; set; }

        public Wynagrodzenie(int lp)
        {
            Liczba_porzad = lp;
        }


    }
}
