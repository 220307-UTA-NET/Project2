using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Web.Site.Controllers.Persistance
{
	public class SignalDataModel
    {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int Id { get; set; }
	}
		
	
}

