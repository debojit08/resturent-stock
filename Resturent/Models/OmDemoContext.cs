using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Resturent.Models
{
    public partial class OmDemoContext : DbContext
    {
        public OmDemoContext()
        {
        }

        public OmDemoContext(DbContextOptions<OmDemoContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<StockPurch> StockPurches { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; Database=OmDemo; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

          
            modelBuilder.Entity<StockPurch>(entity =>
            {
                entity.HasKey(e => e.PurchesItemId)
                    .HasName("Pk_PurchesItemID");

                entity.ToTable("StockPurches", "Config");

                entity.Property(e => e.PurchesItemId).HasColumnName("PurchesItemID");

                entity.Property(e => e.Cgst).HasColumnName("CGST");

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eDate");

                entity.Property(e => e.ItemName).IsUnicode(false);

                entity.Property(e => e.MDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mDate");

                entity.Property(e => e.PaymentType).HasDefaultValueSql("((0))");

                entity.Property(e => e.PricePerUnit).IsUnicode(false);

                entity.Property(e => e.Sgst).HasColumnName("SGST");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier", "Config");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("eDate");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mDate");

                entity.Property(e => e.MobileNo).HasColumnName("Mobile_no");

                entity.Property(e => e.SupplierName).IsUnicode(false);
            });

          

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
