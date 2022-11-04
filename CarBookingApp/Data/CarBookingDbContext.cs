using CarBookingApp.Model;
using Microsoft.EntityFrameworkCore;

namespace CarBookingApp.Data
{
    public class CarBookingDbContext : DbContext
    {
        public CarBookingDbContext(DbContextOptions options) : base(options)
        {
        }

         public DbSet<Car> Cars { get; set; } 
    }
}
