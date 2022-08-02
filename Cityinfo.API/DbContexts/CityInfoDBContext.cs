using Cityinfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cityinfo.API.DbContexts
{
    public class CityInfoDBContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!; //Null forgiving operator

        public DbSet<PointOfInterest> PointOfInterests {get;set;} = null!;
    }
}
