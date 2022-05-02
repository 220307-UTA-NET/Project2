using Microsoft.EntityFrameworkCore;
using Webpet.data;

namespace Webpet.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<pet_image> Images { get; set; }
        public DbSet<AnimalName> animal_Names { get; set; }
    }


}
