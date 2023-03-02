using DnDApi.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DnDApi.DataAccess.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {
        }

        public DbSet<Race> Races { get; set; }
        public DbSet<SubRace> SubRaces { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<SubClass> SubClasses { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Race>().ToTable("Race");
            modelBuilder.Entity<SubRace>().ToTable("SubRace");
            modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<SubClass>().ToTable("SubClass");
            modelBuilder.Entity<Feature>().ToTable("Feature");
        }
    }
}
