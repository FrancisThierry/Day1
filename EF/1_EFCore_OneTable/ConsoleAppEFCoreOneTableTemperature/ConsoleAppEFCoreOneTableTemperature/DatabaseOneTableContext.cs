using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEFCoreOneTableTemperature;

public partial class DatabaseOneTableContext : DbContext
{
    public DatabaseOneTableContext()
    {
    }

    public DatabaseOneTableContext(DbContextOptions<DatabaseOneTableContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OneTable> OneTables { get; set; }

    public virtual DbSet<OtherTable> OtherTables { get; set; }

    public virtual DbSet<Table2> Table2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("chaine de cnx");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OneTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC072FD74305");

            entity.ToTable("OneTable");

            entity.Property(e => e.Company).HasColumnType("ntext");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Temperature).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<OtherTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OtherTab__3214EC070B1EC1A8");

            entity.ToTable("OtherTable");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Table2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC077DD96EC7");

            entity.ToTable("Table2");

            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
