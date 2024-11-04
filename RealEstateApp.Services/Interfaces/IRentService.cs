using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;

namespace RealEstateApp.Services.Interfaces
{
	public interface IRentService
	{
        Task<BaseResponseModel> CreateRent(RentRequestViewModel model, Guid createdBy);

    }
}
