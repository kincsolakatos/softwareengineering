using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReceptesAdatbazis.Models;

[Table("MennyisegiEgysegek", Schema = "dbo")]
public partial class MennyisegiEgysegek
{
    [Key]
    [Column("MennyisegiEgysegID")]
    public int MennyisegiEgysegId { get; set; }

    [StringLength(50)]
    public string? EgysegNev { get; set; }

    [InverseProperty("MennyisegiEgyseg")]
    public virtual ICollection<Nyersanyagok> Nyersanyagok { get; set; } = new List<Nyersanyagok>();
}
