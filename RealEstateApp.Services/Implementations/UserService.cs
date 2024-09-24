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
	public class UserService: IUserService
	{
		public UserService() 
		{ 
		}

		public Task<BaseResponseModel> CreateUser(UserRequestViewModel model)
		{
			throw new NotImplementedException();
		}

		public Task<BaseResponseModel> UpdatePassword(PasswordUpdateRequestModel model)
		{
			throw new NotImplementedException();
		}

		public Task<BaseResponseModel> UpdateUser(UserUpdateRequestModel model)
		{
			throw new NotImplementedException();
		}
	}
}
