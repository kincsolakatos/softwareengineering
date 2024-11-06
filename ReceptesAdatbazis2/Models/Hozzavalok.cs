using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptesAdatbazis2.Models
{
    public class Hozzavalok
    {
        public int ReceptId { get; set; }
        public string FogasNev { get; set; }
        public string NyersanyagNev { get; set; }
        public double? Mennyiseg4fo { get; set; }
        public string MennyisegiEgyseg { get; set; }
        public decimal? Egysegar {  get; set; }
        public double? Ar {  get; set; }

    }
}
