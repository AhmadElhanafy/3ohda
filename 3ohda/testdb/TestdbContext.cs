using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _3ohda.testdb;

public partial class TestdbContext : DbContext
{
    public TestdbContext()
    {
    }

    public TestdbContext(DbContextOptions<TestdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Custody> Custodies { get; set; }

    public virtual DbSet<CustodyItem> CustodyItems { get; set; }

    public virtual DbSet<CustodyItemStatus> CustodyItemStatuses { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Item1> Items1 { get; set; }

    public virtual DbSet<ItemStatus> ItemStatuses { get; set; }

    public virtual DbSet<Personel> Personels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=127.0.0.1; database=testdb; uid=root; pwd=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(45);
        });

        modelBuilder.Entity<Custody>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("custody");

            entity.HasIndex(e => e.PersonelId, "PersonelID_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateTaken).HasColumnType("date");
            entity.Property(e => e.PersonelId).HasColumnName("PersonelID");
            entity.Property(e => e.PlaceTaken).HasMaxLength(45);

            entity.HasOne(d => d.Personel).WithMany(p => p.Custodies)
                .HasForeignKey(d => d.PersonelId)
                .HasConstraintName("PersonelID");
        });

        modelBuilder.Entity<CustodyItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("custody_item");

            entity.HasIndex(e => e.CustodyItemStatusId, "CustodtItemStatusID_idx");

            entity.HasIndex(e => e.CustodyId, "CustodyID_idx");

            entity.HasIndex(e => e.ItemId, "ItemID_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustodyId).HasColumnName("CustodyID");
            entity.Property(e => e.CustodyItemStatusId).HasColumnName("CustodyItemStatusID");
            entity.Property(e => e.DateReturned).HasColumnType("date");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Custody).WithMany(p => p.CustodyItems)
                .HasForeignKey(d => d.CustodyId)
                .HasConstraintName("CustodyID");

            entity.HasOne(d => d.CustodyItemStatus).WithMany(p => p.CustodyItems)
                .HasForeignKey(d => d.CustodyItemStatusId)
                .HasConstraintName("CustodtItemStatusID");

            entity.HasOne(d => d.Item).WithMany(p => p.CustodyItems)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("ItemID");
        });

        modelBuilder.Entity<CustodyItemStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("custody_item_status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(45);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("item");

            entity.HasIndex(e => e.CategoryId, "CategoryID_idx");

            entity.HasIndex(e => e.StatusId, "StatusID_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Name).HasMaxLength(45);
            entity.Property(e => e.Notes).HasMaxLength(45);
            entity.Property(e => e.Place).HasMaxLength(45);
            entity.Property(e => e.SerialNumber).HasMaxLength(45);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Category).WithMany(p => p.Items)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("CategoryID");

            entity.HasOne(d => d.Status).WithMany(p => p.Items)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("StatusID");
        });

        modelBuilder.Entity<Item1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("items");

            entity.HasIndex(e => e.Id, "ID_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateReturned).HasColumnType("date");
            entity.Property(e => e.DateTaken)
                .HasDefaultValueSql("'curdate()'")
                .HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(45);
            entity.Property(e => e.NameOfTaker).HasMaxLength(45);
            entity.Property(e => e.NotesOnReturn).HasMaxLength(45);
            entity.Property(e => e.PlaceTaken).HasMaxLength(45);
            entity.Property(e => e.Quantity).HasDefaultValueSql("'1'");
            entity.Property(e => e.QuantityReturned).HasDefaultValueSql("'0'");
            entity.Property(e => e.SerialNumber).HasMaxLength(45);
            entity.Property(e => e.Type).HasMaxLength(45);
        });

        modelBuilder.Entity<ItemStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("item_status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(45);
        });

        modelBuilder.Entity<Personel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("personel");

            entity.HasIndex(e => e.Id, "ID_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(45);
            entity.Property(e => e.Rank).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
