using firmaAndmebaas.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace firmaAndmebaas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Tervisekontroll> Tervisekontroll { get; set; }
        public DbSet<Ametinimetus> Ametinimetus { get; set; }
        public DbSet<LaenutatavadAsjad> LaenutatavadAsjad { get; set; }
        public DbSet<Laenutus> Laenutus { get; set; }
        public DbSet<Firma> Firma { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Puhkepäevad> Puhkepäevad { get; set; }
        public DbSet<Haigusleht> Haigusleht { get; set; }
        public DbSet<Lapsed> Lapsed { get; set; }
        public DbSet<Ligipääasuluba> Ligipääasuluba { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ühendused
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Tervisekontrollid)
                .WithOne(t => t.Employee)
                .HasForeignKey(t => t.EmployeeID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Laenutused)
                .WithOne(l => l.Employee)
                .HasForeignKey(l => l.EmployeeID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Puhkepäevad)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeID);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany(p => p.Employees)
                .HasForeignKey(e => e.PositionID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Ligipääasuload)
                .WithOne(a => a.Employee)
                .HasForeignKey(a => a.EmployeeID);

            modelBuilder.Entity<Ametinimetus>()
                .HasMany(p => p.Employees)
                .WithOne(e => e.Position)
                .HasForeignKey(e => e.PositionID);

            modelBuilder.Entity<Firma>()
                .HasMany(f => f.Employees)
                .WithOne(e => e.Firma)
                .HasForeignKey(e => e.FirmaID);

            modelBuilder.Entity<LaenutatavadAsjad>()
                .HasMany(i => i.Laenutused)
                .WithOne(l => l.LaenutatavadAsjad)
                .HasForeignKey(l => l.ItemID);
        }
    }
}