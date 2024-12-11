using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cseresznye_IASR1J_Web.Models
{
    [Index("Email", Name = "UQ__Users__A9D10534E9D59CD3", IsUnique = true)]
    public partial class Users
    {
        public Users()
        {
            Rides = new HashSet<Rides>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; } = null!;
        [StringLength(100)]
        public string Email { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? RegistrationDate { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Rides> Rides { get; set; }
    }
}
