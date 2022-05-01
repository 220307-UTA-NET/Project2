using Microsoft.EntityFrameworkCore;

namespace Webpet.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<pet_image> Images { get; set; }
    }


}
