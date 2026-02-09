using Microsoft.EntityFrameworkCore;


namespace HobartEats.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //public DbSet<Restaurant> Restaurants { get; set; }


    }
}
