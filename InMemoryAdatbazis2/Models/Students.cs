using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryAdatbazis2.Models
{
    public class Students
    {
        public string Neptun {  get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal? AverageGrade { get; set; }
        public bool IsActive { get; set; }
    }
}
