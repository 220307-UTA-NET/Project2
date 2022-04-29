using System;
using Web.Site.Controllers.Models;

namespace Web.Site.Controllers.Services
{
	public class ISignalService
	{
		public ISignalService()
		{
			Task<bool> SaveSignalAsync(SignalInputModel inputModel);
		}
	}
}

