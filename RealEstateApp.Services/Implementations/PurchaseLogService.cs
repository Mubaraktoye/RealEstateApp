using RealEstateApp.Model.Data;
using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;
using RealEstateApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Services.Implementations
{
	public class PurchaseLogService : IPurchaseLogService
	{
		public PurchaseLogService() 
		{
		}

		public Task<BaseResponseModel> CreateRentLog(PurchaseLogRequestViewModel model)
		{
			var purchaseLog = new PurchaseLog
			{
				PurchaseId = Guid.NewGuid(),
				Message = model.Message,
				VisitorEmail = model.VisitorEmail,
				VisitorName = model.VisitorName,
				VisitorPhoneNumber = model.VisitorPhoneNumber,
				CreatedDate = DateTime.Now,
			};
			throw new NotImplementedException();
		}

		public Task<PurchaseLogListResponseModel> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<PurchaseLogListResponseModel> GetAllBy(LogQueryRequestModel queryParams)
		{
			throw new NotImplementedException();
		}

		public Task<PurchaseLogResponseModel> GetById()
		{
			throw new NotImplementedException();
		}
	}
}
