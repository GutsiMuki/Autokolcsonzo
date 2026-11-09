using Autokolcsonzo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokolcsonzo.Services
{
    public class AutokolcsonzoDbContext : DbContext
    {
        string c = "Server=localhost;Database=autokolcsonzo_gyakorlat;Uid=root;Pwd=root;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>().HasOne(a => a.Gyarto).WithMany(k=>k.Autok).HasForeignKey(a => a.GyartoId);

            modelBuilder.Entity<Auto>().HasOne(a => a.Kategoria).WithMany(k => k.Autok).HasForeignKey(a => a.KategoriaId);

            modelBuilder.Entity<Berles>().HasOne(b => b.Auto).WithMany(a => a.Berlesek).HasForeignKey(a => a.Id);

            modelBuilder.Entity<Berles>().HasOne(b => b.Ugyfel).WithMany(u => u.Berlesek).HasForeignKey(b => b.UgyfelId);

            modelBuilder.Entity<Auto>().ToTable("autok");
            modelBuilder.Entity<Berles>().ToTable("Berlesek");
            modelBuilder.Entity<Kategoria>().ToTable("Kategoriak");
            modelBuilder.Entity<Ugyfel>().ToTable("Ugyfelek");
            modelBuilder.Entity<Gyarto>().ToTable("Gyartok");
        }

        public DbSet<Auto> DbAuto { get; set; }
        public DbSet<Berles> DbBerles { get; set; }
        public DbSet<Kategoria> DbKategoria { get; set; }
        public DbSet<Ugyfel> DbUgyfel { get; set; }
        public DbSet<Gyarto> DbGyarto { get; set;}
    }
}
