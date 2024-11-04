using AutoMapper;
using RealEstateApp.Model.Data;
using RealEstateApp.Model.ViewModel.Responses;

namespace RealEstateApp.Services.DIExtention
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            Config();
        }

        public void Config()
        {
            CreateMap<Rent, RestResponse>().ReverseMap();
            CreateMap<User, UserResponseModel>().ReverseMap();

        }
    }
}
