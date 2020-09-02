using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using inffrd_assignment.Models;

namespace inffrd_assignment.DatabaseContext
{
    public partial class InffrdDBContext : DbContext
    {
        public InffrdDBContext()
        {
        }

        public InffrdDBContext(DbContextOptions<InffrdDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-B06KC08\\SQLEXPRESS01;Initial Catalog=Infrrd;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Expenses>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Year).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Expenses_Expenses");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
