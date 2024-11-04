using Arch.EntityFrameworkCore.UnitOfWork;
using AutoMapper;
using RealEstateApp.Core.Constants;
using RealEstateApp.Model.Data;
using RealEstateApp.Model.Enum;
using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;
using RealEstateApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RealEstateApp.Services.Implementations
{
	public class UserService: IUserService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseModel> CreateUser(UserRequestViewModel model)
		{
            try
            {
                var sha = new System.Security.Cryptography.SHA256Managed();

                User user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Password = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(model.Password))).Replace("-", String.Empty)
                };

                await _unitOfWork.GetRepository<User>().InsertAsync(user);
                _unitOfWork.SaveChanges();

                  return new BaseResponseModel
                {
                    Status = true,
                    Message = Response.RegisteredSuccessfully
                  };
            }
            catch (Exception ex)
            {

            }
            return new BaseResponseModel
            {
                Status = false,
                Message = Response.Failed
            };
        }

        public async Task<LoginResponseModel> LoginUser(UserLoginViewModel model)
        {
            //To rewrite   
            try
            {
                var sha = new System.Security.Cryptography.SHA256Managed();
                
                var user = await _unitOfWork.GetRepository<User>().GetFirstOrDefaultAsync(x => x.Email == model.Email, null, null, false);
                if(user != null)
                {
                    var hashPass = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(model.Password))).Replace("-", String.Empty);
                    if (string.Equals(user.Password, hashPass))
                    {
                        return new LoginResponseModel
                        {
                            Status = true,
                            Message = Response.Successful,
                            Data = _mapper.Map<UserResponseModel>(user),
                            Token = null,
                            RefreshToken = null
                        };
                    }
                }
                return new LoginResponseModel
                {
                    Status = false,
                    Message = Response.LoginFailed
                };
            }
            catch (Exception ex)
            {
            }
            return new LoginResponseModel
            {
                Status = false,
                Message = Response.LoginFailed
            };
        }

        public Task<BaseResponseModel> UpdatePassword(PasswordUpdateRequestModel model)
		{
			throw new NotImplementedException();
		}

		public Task<BaseResponseModel> UpdateUser(UserUpdateRequestModel model)
		{
			throw new NotImplementedException();
		}

        private static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        //private static string GetHashString(string inputString)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (byte b in GetHash(inputString))
        //        sb.Append(b.ToString("X2"));

        //    return sb.ToString();
        //}
    }
}
