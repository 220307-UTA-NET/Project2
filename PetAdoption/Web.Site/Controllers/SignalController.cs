using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Site.Controllers.Models;
//using Web.Site.Models;
//using Web.Site.Services;


namespace Web.Site.Controllers
{
	[Route("api/v1/signals")]
	[ApiController]

	public class SignalController : ControllerBase
	{
		[HttpPost]
		[Route("delivaryPonit")]
		[ProducesResponseType(404)]
		[ProducesResponseType(200, Type = typeof(bool))]

		public async Task<IActionResult> SignalArrived(SignalInputModel inputmodel)
        {

			//let’s define what we might need to do when a signal arrived in our API:
			//Log the signal input
			//Validate the signal input
			//Save the signal
			//Log the operation result
			//Return an acknowledge(a result) to the requester(client)
			//Notify the clients
			


		}



    }

			
        }


		
	}

}

//The simple explanation of the method is that we have a SignalArrived() method
//and this method can be accessed via “yourapiaddress.com/api/v1/signals/deliverypoint”
//when a HttpPost request is made. If the method cannot be accessible an Http 404 (Not Found)
//message turns as a response. Otherwise, if the method completes operations successfully
//then a boolean result with an Http 200 (Success) message is returned.
//to increase the scenario complexity, we can also implement Http 400 (Bad Request) scenario.
