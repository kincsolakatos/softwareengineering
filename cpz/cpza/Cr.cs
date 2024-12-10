﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpza
{
    public class Cr
    {
        public int RideId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string StartLocation { get; set; } = string.Empty;
        public string EndLocation { get; set; } = string.Empty;
        public DateTime RideDate { get; set; }
        public decimal DistanceKm { get; set; }
    }
}
