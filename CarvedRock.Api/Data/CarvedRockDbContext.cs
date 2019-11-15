using CarvedRock.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarvedRock.Api.Data
{
    public class CarvedRockDbContext: DbContext
    {
        public CarvedRockDbContext(DbContextOptions<CarvedRockDbContext> options): base(options)
        {           
        }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
