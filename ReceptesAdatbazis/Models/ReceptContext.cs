using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReceptesAdatbazis.Models;

public partial class ReceptContext : DbContext
{
    public ReceptContext()
    {
    }

    public ReceptContext(DbContextOptions<ReceptContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Fogasok> Fogasok { get; set; }

    public virtual DbSet<MennyisegiEgysegek> MennyisegiEgysegek { get; set; }

    public virtual DbSet<Nyersanyagok> Nyersanyagok { get; set; }

    public virtual DbSet<Receptek> Receptek { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=Etkeztetes;User ID=hallgato;Password=Password123;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MennyisegiEgysegek>(entity =>
        {
            entity.Property(e => e.MennyisegiEgysegId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Nyersanyagok>(entity =>
        {
            entity.HasOne(d => d.MennyisegiEgyseg).WithMany(p => p.Nyersanyagok).HasConstraintName("FK_Nyersanyagok_MennyisegiEgysegek");
        });

        modelBuilder.Entity<Receptek>(entity =>
        {
            entity.HasOne(d => d.Fogas).WithMany(p => p.Receptek).HasConstraintName("FK_Receptek_Fogasok");

            entity.HasOne(d => d.Nyersanyag).WithMany(p => p.Receptek).HasConstraintName("FK_Receptek_Nyersanyagok");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
