
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StarWarsTroopers.Model;

namespace StarWarsTroopers.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Trooper> Troopers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<Trooper>().ToTable("Troopers");

            // Configure Primary Keys  
            modelBuilder.Entity<Trooper>().HasKey(u => u.id).HasName("PK_Troopers");

            // Configure indexes  
            modelBuilder.Entity<Trooper>().HasIndex(u => u.homeworld).HasDatabaseName("Idx_Troopers_homeworld");

            // Configure columns  
            modelBuilder.Entity<Trooper>().Property(u => u.id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Trooper>().Property(u => u.name).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Trooper>().Property(u => u.height).HasColumnType("decimal(5,2)").IsRequired();
            modelBuilder.Entity<Trooper>().Property(u => u.homeworld).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Trooper>().Property(u => u.gender).HasColumnType("nvarchar(15)").IsRequired(false);
            modelBuilder.Entity<Trooper>().Property(u => u.specie).HasColumnType("nvarchar(100)").IsRequired(false);
            modelBuilder.Entity<Trooper>().Property(u => u.created).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Trooper>().Property(u => u.edited).HasColumnType("datetime").IsRequired();
        }
    }

}
