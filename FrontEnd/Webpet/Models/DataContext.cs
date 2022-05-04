using Microsoft.EntityFrameworkCore;
using Webpet.data;


namespace Webpet.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<pet_image> Images { get; set; }
        
        public DbSet<animal_name> animal_Names { get; set; }

        public DbSet<User_Data> User { get; set; }

        public DbSet<pet_profile> Pet { get; set; }

<<<<<<< HEAD
        public DbSet<pet_Dates_Table> PetDate { get; set; }



=======
>>>>>>> 0bb0a5d73ed3f565d604954ad8a7a63fa66e288d
    }


}
