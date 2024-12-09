using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryPickingZHApp
{
    public class RidesDTO
    {
        public string UserName { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime RideDate { get; set; }
        public decimal DistanceKm { get; set; }
    }
}
