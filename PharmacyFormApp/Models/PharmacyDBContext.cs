using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PharmacyFormApp.Models
{
    public partial class PharmacyDBContext : DbContext
    {
        public PharmacyDBContext()
        {
        }

        public PharmacyDBContext(DbContextOptions<PharmacyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagToMedicine> TagToMedicines { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HOME-PC; initial catalog=PharmacyDB; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Firm>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.Medicines)
                    .HasForeignKey(d => d.FirmId)
                    .HasConstraintName("FK__Medicines__FirmI__267ABA7A");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK__Orders__Medicine__32E0915F");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.WorkerId)
                    .HasConstraintName("FK__Orders__WorkerId__33D4B598");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TagToMedicine>(entity =>
            {
                entity.HasKey(e => e.TagMedicineId)
                    .HasName("PK__Tag_To_M__7D113813FE827869");

                entity.ToTable("Tag_To_Medicine");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.TagToMedicines)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK__Tag_To_Me__Medic__2C3393D0");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagToMedicines)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK__Tag_To_Me__TagId__2B3F6F97");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
