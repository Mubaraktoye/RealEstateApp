using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;

namespace RealEstateApp.Services.Interfaces
{
	public interface IPurchaseLogService
	{
		Task<BaseResponseModel> CreateRentLog(PurchaseLogRequestViewModel model);
		Task<PurchaseLogListResponseModel> GetAll();
		Task<PurchaseLogResponseModel> GetById();
		Task<PurchaseLogListResponseModel> GetAllBy(LogQueryRequestModel queryParams);
	}
}
