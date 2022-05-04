using System.ComponentModel.DataAnnotations;

namespace Webpet.Models
{
    public class pet_profile
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] image { get; set; }
        public string ContentType { get; set; }
        public string Pet_Name { get; set; }
        public string Pet_behavior { get; set; }



    }
}
