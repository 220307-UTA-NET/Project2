
using System.ComponentModel.DataAnnotations.Schema;

namespace Webpet.data
{
    public class pet_image_data
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] image { get; set; }
        public string ContentType { get; set; }


    }
}
