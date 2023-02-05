using _01_Entity.Concrete;
using _02_DAL.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DAL.Context
{
    public class ProjectContext:DbContext
    {
        public DbSet<AlbumBilgi> AlbumBilgileri { get; set; }

        public DbSet<Yonetici> Yoneticiler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                object value = optionsBuilder.UseSqlServer("Server=.;Database=PlakDukkani;Trusted_Connection=True;Encrypt=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumBilgiMapping());
            modelBuilder.ApplyConfiguration(new YoneticiMapping());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
