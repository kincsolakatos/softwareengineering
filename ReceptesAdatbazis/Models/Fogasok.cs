using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReceptesAdatbazis.Models;

[Table("Fogasok", Schema = "dbo")]
public partial class Fogasok
{
    [Key]
    [Column("FogasID")]
    public int FogasId { get; set; }

    [StringLength(50)]
    public string? FogasNev { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Kep { get; set; }

    public string? Leiras { get; set; }

    [InverseProperty("Fogas")]
    public virtual ICollection<Receptek> Receptek { get; set; } = new List<Receptek>();
}
