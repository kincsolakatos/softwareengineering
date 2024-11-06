using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReceptesAdatbazis.Models;

[Table("Nyersanyagok", Schema = "dbo")]
public partial class Nyersanyagok
{
    [Key]
    [Column("NyersanyagID")]
    public int NyersanyagId { get; set; }

    [StringLength(50)]
    public string? NyersanyagNev { get; set; }

    [Column("MennyisegiEgysegID")]
    public int? MennyisegiEgysegId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Egysegar { get; set; }

    [ForeignKey("MennyisegiEgysegId")]
    [InverseProperty("Nyersanyagok")]
    public virtual MennyisegiEgysegek? MennyisegiEgyseg { get; set; }

    [InverseProperty("Nyersanyag")]
    public virtual ICollection<Receptek> Receptek { get; set; } = new List<Receptek>();
}
