using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Webpet.Models
{
    public class animal_name
    {
        [Key]
        public string? anmial_id { get; set; }
        public string? anmial_name { get; set; }
    }
}