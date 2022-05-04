using System;
using Web.Site.Controllers.Models;
using System.Threading.Tasks;
using Web.Site.Controllers.Persistance;

//we first inject MainDbContext for database operations, then implement the
//method by mapping the input model to the data model.  As a final step, we add the signal
//into the context and save it asynchronously.
//Our singal save feature is now ready and the next step is coding realtime notification feature.

namespace Web.Site.Controllers.Services
{
	
	public class SignalService : ISignalService
	{
		private readonly MainDbContext _mainDbContext;

		public SignalService(MainDbContext mainDbContext)
        {
			_mainDbContext = mainDbContext;

        }

		public async Task<bool> SaveSignalAsync(SignalInputModel inputModel)
        {
			try
			{
				//map input model to data model
				//at this point we assume a signal arrives only one time and it's unique

				SignalDataModel signalModel = new SignalDataModel();
				signalModel.CustomerName = inputModel.CustomerName;
				signalModel.Description = inputModel.Description;
				signalModel.AccessCode = inputModel.AccessCode;
				signalModel.Area = inputModel.Area;
				signalModel.Zone = inputModel.Zone;
				signalModel.SignalDate = DateTime.Now;

				//execute some business rules according to your cases.

				//if you decide to save signal add it to the db context
				_mainDbContext.Signals.Add(signalModel);

				//save changes and if the signal has stored in db return true.
				return await _mainDbContext.SaveChangesAsync() > 0;



			}
			catch (Exception exception)
            {
				//log the exception or take some actions
				return false;
            }
        }


	}
}


