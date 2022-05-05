using System.ComponentModel.DataAnnotations;

namespace Webpet.data
{
    public class animals_names
    {
        [Key]
        public string anmial_id { get; set; }
        public string? anmial_name { get; set; }



    }
}