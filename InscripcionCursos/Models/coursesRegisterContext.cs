using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InscripcionCursos.Models
{
    public partial class coursesRegisterContext : DbContext
    {
        public coursesRegisterContext()
        {
        }

        public coursesRegisterContext(DbContextOptions<coursesRegisterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=coursesRegister;User Id=sa;Password=sasql");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.IdCourse);

                entity.ToTable("courses");

                entity.Property(e => e.IdCourse).HasColumnName("id_Course");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.IdStudent);

                entity.ToTable("students");

                entity.Property(e => e.IdStudent).HasColumnName("id_Student");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IdCourse).HasColumnName("id_Course");

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCourseNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdCourse)
                    .HasConstraintName("FK__students__phone__4BAC3F29");
            });
        }
    }
}
