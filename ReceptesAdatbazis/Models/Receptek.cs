using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReceptesAdatbazis.Models;

[Table("Receptek", Schema = "dbo")]
public partial class Receptek
{
    [Key]
    [Column("ReceptID")]
    public int ReceptId { get; set; }

    [Column("FogasID")]
    public int? FogasId { get; set; }

    [Column("NyersanyagID")]
    public int? NyersanyagId { get; set; }

    [Column("Mennyiseg_4fo")]
    public double? Mennyiseg4fo { get; set; }

    [ForeignKey("FogasId")]
    [InverseProperty("Receptek")]
    public virtual Fogasok? Fogas { get; set; }

    [ForeignKey("NyersanyagId")]
    [InverseProperty("Receptek")]
    public virtual Nyersanyagok? Nyersanyag { get; set; }
}
