using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CherryPickingZH.Models;

public partial class Rides
{
    [Key]
    [Column("RideID")]
    public int RideId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(100)]
    public string StartLocation { get; set; } = null!;

    [StringLength(100)]
    public string EndLocation { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RideDate { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal DistanceKm { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Rides")]
    public virtual Users User { get; set; } = null!;
}
