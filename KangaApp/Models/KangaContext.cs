using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KangaApp.Models
{
    public partial class KangaContext : DbContext
    {
        public KangaContext()
        {
        }

        public KangaContext(DbContextOptions<KangaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Kanga;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ProductNumber);

                entity.ToTable("Client");

                entity.Property(e => e.ProductNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("Product Number");

                entity.Property(e => e.ClientAddress)
                    .IsUnicode(false)
                    .HasColumnName("Client Address");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Client Name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phone Number");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Product Name");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductNumber);

                entity.ToTable("Product");

                entity.Property(e => e.ProductNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("Product Number");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsUnicode(false)
                    .HasColumnName("Product Name");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.VendorId)
                    .ValueGeneratedNever()
                    .HasColumnName("Vendor Id");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phone Number");

                entity.Property(e => e.ProductNumber).HasColumnName("Product Number");

                entity.Property(e => e.VendorAddress)
                    .IsUnicode(false)
                    .HasColumnName("Vendor Address");

                entity.Property(e => e.VendorEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Vendor Email");

                entity.Property(e => e.VendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Vendor Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
