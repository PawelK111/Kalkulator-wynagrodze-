using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wynagrodzenia
{
    public class Wynagrodzenie
    {
        public string liczba_porzad { get; set; }
        public string placa_podstawowa { get; set; }
        public string dodatki { get; set; }
        public string wynagr_brutto { get; set; }
        public string ubezp_emerytalne { get; set; }

        public string ubezp_rentowe { get; set; }
        public string ubezp_chorobowe { get; set; }
        public string ubezp_zdrowotne { get; set; }
        public string podatekUS { get; set; }
        public string wynagr_netto { get; set; }

    }
}
