using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendeles_Forms_IASR1J
{
    public class RendelesTetelDTO
    {
        public int TetelId
        {
            get;
            set;
        }
        public string? TermekNev
        {
            get;
            set;
        }
        public int Mennyiseg
        {
            get;
            set;
        }
        public decimal EgysegAr
        {
            get;
            set;
        }
        public decimal Afa
        {
            get; 
            set;
        }
        public decimal NettoAr
        {
            get; 
            set;
        }
        public decimal BruttoAr
        {
            get;
            set;
        }
    }
}
