using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryPickingZH
{
    public class RidesDTO
    {
        public int RideId { get; set; }
        public string UserName { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime RideDate { get; set; }
        public decimal DistanceKm { get; set; }
    }
}
