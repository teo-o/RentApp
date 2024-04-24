using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Rentapp.Shared.Entities;

namespace Rentapp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brand>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Car>().HasIndex(x => x.LicensePlate).IsUnique();
            modelBuilder.Entity<CarCategory>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<City>().HasIndex("StateId", "Name").IsUnique();
            modelBuilder.Entity<Rent>().HasIndex(x => x.Id).IsUnique();
            modelBuilder.Entity<State>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.Document).IsUnique();
            DisableCascadingDelete(modelBuilder);
        }

        private void DisableCascadingDelete(ModelBuilder modelBuilder)
        {
            var relationships = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys());
            foreach (var relationship in relationships)
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
