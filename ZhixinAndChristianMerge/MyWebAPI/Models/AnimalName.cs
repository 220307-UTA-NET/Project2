using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Webpet.Models
{
    public class AnimalName
    {
        public string? Animal_name { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int animal_Id { get; set; }

        public AnimalName() { }

    }
}