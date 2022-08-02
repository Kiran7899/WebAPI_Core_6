using Cityinfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cityinfo.API.DbContexts
{
    public class CityInfoDBContext : DbContext
    {
        public CityInfoDBContext(DbContextOptions<CityInfoDBContext> options)
            : base(options)
        {

        }
        public DbSet<City> Cities { get; set; } = null!; //Null forgiving operator

        public DbSet<PointOfInterest> PointOfInterests {get;set;} = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City("Chennai") { Id = 1,Description = "Chennai"},
                new City("Bangalore") { Id = 2,Description = "Bengaluru"}                
                );

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest("Marina Beach") { CityId = 1, Description = "Sea"},
                new PointOfInterest("Mall") { CityId = 2, Description = "Shop" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
