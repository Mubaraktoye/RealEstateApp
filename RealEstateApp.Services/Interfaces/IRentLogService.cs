using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;

namespace RealEstateApp.Services.Interfaces
{
	public interface IRentLogService
	{
		Task<BaseResponseModel> CreateRentLog(RentLogRequestViewModel model);
		Task<RentLogListResponseModel> GetAll();
		Task<RentLogListResponseModel> GetAllBy(LogQueryRequestModel queryParams);
		Task<RentLogResponseModel> GetById(Guid Id);

	}
}
