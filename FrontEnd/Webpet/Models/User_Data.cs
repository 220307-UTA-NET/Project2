using System.ComponentModel.DataAnnotations;

namespace Webpet.Models
{
    public class User_Data
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_FirstName { get; set; }
        public string user_LastName { get; set; }
        public string user_Password { get; set; }

    }
}
