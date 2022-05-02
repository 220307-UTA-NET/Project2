using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Webpet.data
{
    public partial class animals_names
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? animal_id { get; set; }
        public string? animal_name { get; set; }
    }
}
//[key]

//[DatabaseGenerated(DatabaseGeneratedOption.None)]

//public int Id { get; set; }

//public string Model { get; set; }

//public DateTime Registered { get; set; }