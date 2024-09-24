using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Services.Interfaces
{
	public interface IUserService
	{
		Task<BaseResponseModel> CreateUser(UserRequestViewModel model);
		Task<BaseResponseModel> UpdateUser(UserUpdateRequestModel model);
		Task<BaseResponseModel> UpdatePassword(PasswordUpdateRequestModel model);
	}
}
