using System.ComponentModel.DataAnnotations;

namespace Webpet.Models
{
    public class pet_image
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] image { get; set; }

        public string ContentType { get; set; }

    }
    
}
