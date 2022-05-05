using System.ComponentModel.DataAnnotations;

namespace Webpet.data
{
    public class pet_image_data
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] image { get; set; }
        public string ContentType { get; set; }
    }
}
