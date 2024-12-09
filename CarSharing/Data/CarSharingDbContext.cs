using System;
using System.Collections.Generic;
using CarSharing.Models;
using Microsoft.EntityFrameworkCore;

namespace CarSharing.Data;

public partial class CarSharingDbContext : DbContext
{
    public CarSharingDbContext()
    {
    }

    public CarSharingDbContext(DbContextOptions<CarSharingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Rides> Rides { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=iasr1j.database.windows.net;Initial Catalog=CarSharingDB;Persist Security Info=True;User ID=iasr1j;Password=Password1234;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rides>(entity =>
        {
            entity.HasKey(e => e.RideId).HasName("PK__Rides__C5B8C414572504E0");

            entity.HasOne(d => d.User).WithMany(p => p.Rides)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rides__UserID__619B8048");
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC294944BF");

            entity.Property(e => e.RegistrationDate).HasDefaultValueSql("(getdate())");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
