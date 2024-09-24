using Arch.EntityFrameworkCore.UnitOfWork;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Core.Constants;
using RealEstateApp.Model.Data;
using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;
using RealEstateApp.Services.Interfaces;

namespace RealEstateApp.Services.Implementations
{
    public class RentLogService: IRentLogService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public RentLogService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseModel> CreateRentLog(RentLogRequestViewModel model)
		{
			if (model != null) 
			{
                var rentLog = new RentLog
                {
					Id= Guid.NewGuid(),
                    Message = model.Message,
                    VisitorName = model.VisitorName,
                    VisitorPhoneNumber = model.VisitorPhoneNumber,
                    VisitorEmail = model.VisitorEmail,
                    CreatedDate = DateTime.Now
                };
                await _unitOfWork.GetRepository<RentLog>().InsertAsync(rentLog);
                _unitOfWork.SaveChanges();
            }
            return new BaseResponseModel
            {
                Status = true,
                Message = Response.Successful
            };


            throw new NotImplementedException();
		}

		public async Task<RentLogListResponseModel> GetAll()
		{
            var dataResponse = await _unitOfWork.GetRepository<RentLog>().GetAllAsync();
            var mappedResponse = _mapper.Map<List<RentLogResponse>>(dataResponse);
            
            return new RentLogListResponseModel
            {
                Status = true,
                Message = Response.Successful,
                Data = mappedResponse
            };
		}

		public async Task<RentLogListResponseModel> GetAllBy(LogQueryRequestModel queryParams)
		{
            var dataResponse = await _unitOfWork.GetRepository<RentLog>().GetAllAsync(x => x.IsContacted == queryParams.IsContacted || x.CreatedDate == queryParams.Date);
            var mappedResponse = _mapper.Map<List<RentLogResponse>>(dataResponse);

            return new RentLogListResponseModel
            {
                Status = true,
                Message = Response.Successful,
                Data = mappedResponse
            };
        }

		public async  Task<RentLogResponseModel> GetById(Guid id)
		{
            var dataResponse = await _unitOfWork.GetRepository<RentLog>().GetFirstOrDefaultAsync(x => x.Id == id, null, null, false);
            var mappedResponse = _mapper.Map<RentLogResponse>(dataResponse);

            return new RentLogResponseModel
            {
                Status = true,
                Message = Response.Successful,
                Data = mappedResponse
            };
        }
	}
}
