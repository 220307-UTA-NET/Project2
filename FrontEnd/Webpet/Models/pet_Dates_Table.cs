using System.ComponentModel.DataAnnotations;

namespace Webpet.Models
{
    public class pet_Dates_Table
    {

        public int Id { get; set; }
        public int Pet_Id { get; set; }
        public string Pet_Name { get; set; }
        public DateTime date { get; set; }
        public DateTime date2 { get; set; }
    }
}
