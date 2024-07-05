using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleTempWorkBench.Models;

public partial class DatabaseMyTempContext : DbContext
{
    public DatabaseMyTempContext()
    {
    }

    public DatabaseMyTempContext(DbContextOptions<DatabaseMyTempContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<Measure> Measures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("chaine de cnx");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Device__3214EC07044916A8");

            entity.ToTable("Device");

            entity.Property(e => e.DeviceName).HasMaxLength(100);
        });

        modelBuilder.Entity<Measure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Measure__3214EC0788BAE817");

            entity.ToTable("Measure");

            entity.Property(e => e.MeasurementDate).HasColumnType("datetime");

            entity.HasOne(d => d.Device).WithMany(p => p.Measures)
                .HasForeignKey(d => d.DeviceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Device_Measure");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
