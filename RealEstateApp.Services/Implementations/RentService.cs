using Arch.EntityFrameworkCore.UnitOfWork;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RealEstateApp.Core.Constants;
using RealEstateApp.Model.Data;
using RealEstateApp.Model.Enum;
using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;
using RealEstateApp.Services.Interfaces;
using System;
using System.Diagnostics;

namespace RealEstateApp.Services.Implementations
{
    public class RentService: IRentService 
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public RentService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		/// <summary>
		/// This a method for user to create rent property 
		/// </summary>
		/// <param name="model"> </param>
		/// <returns></returns>
		public async Task<BaseResponseModel> CreateRent(RentRequestViewModel model, Guid createdBy)
		{
			try
			{
				Rent rentData = new Rent
				{
					Id = Guid.NewGuid(),
					CreatedDate = DateTime.Now,
					CreatedById = createdBy,
					Location = model.Location,
					Price = model.Price,
					Type = model.Type,
					NoOfRoom = model.NoOfRoom,
					IsGated = model.IsGated,
					Landmark = model.Landmark,
					Status = model.Status,
					ApprovalType = ApprovalType.Pending,
					Description = model.Description
				};
				await _unitOfWork.GetRepository<Rent>().InsertAsync(rentData);
				_unitOfWork.SaveChanges();

				return new BaseResponseModel
				{
					Status = true,
					Message = Response.Successful
				};
			}
			catch(Exception ex)
			{
				
			}
			return new BaseResponseModel
			{
				Status = false,
				Message = Response.Failed
			};
		}

		public async Task<RentListResponseViewModel> GetApprovedRent()
		{
			try
			{
				var dataResponse = await _unitOfWork.GetRepository<Rent>().GetAllAsync(x => x.ApprovalType == ApprovalType.Approved, orderBy: source => source.OrderBy(c => c.Id), "CreatedBy"); //to be optimized on entity framework core extention
				var mappedResponse = _mapper.Map<List<RestResponse>>(dataResponse);
				
				return new RentListResponseViewModel
				{
					Status = true,
					Message = Response.Successful,
					Data = mappedResponse
				};
			}
			catch (Exception)
			{
				
			}
			return new RentListResponseViewModel
			{
				Status = false,
				Message = Response.Failed
			};
		}

		public async Task<RentResponseViewModel> GetRentById(Guid id)
		{
			try
			{
				var dataResponse = _unitOfWork.GetRepository<Rent>().GetFirstOrDefault(x => x.Id == id, null, include: c => c.Include(i => i.CreatedBy).Include(i => i.ModifiedBy), false);
				var mappedResponse = _mapper.Map<RestResponse>(dataResponse);

				return new RentResponseViewModel
				{
					Status = true,
					Message = Response.Successful,
					Data = mappedResponse
				};
			}
			catch (Exception)
			{

			}
			return new RentResponseViewModel
			{
				Status = false,
				Message = Response.Failed
			};
		}

		public async Task<RentResponseViewModel> GetRentByUser(Guid user)
		{
			try
			{
				var dataResponse = _unitOfWork.GetRepository<Rent>().GetFirstOrDefault(x => x.CreatedById == user, null, null, false);
				var mappedResponse = _mapper.Map<RestResponse>(dataResponse);

				return new RentResponseViewModel
				{
					Status = true,
					Message = Response.Successful,
					Data = mappedResponse
				};
			}
			catch (Exception)
			{

			}
			return new RentResponseViewModel
			{
				Status = false,
				Message = Response.Failed
			};
		}
		
		public async Task<BaseResponseModel> UpdateRent (RentUpdateViewModel model, Guid modifiedById)
		{
			try
			{
				var record = _unitOfWork.GetRepository<Rent>().GetFirstOrDefault(x => x.Id == model.Id, null, null, false);

				if (record != null)
				{
					record.Location = string.IsNullOrEmpty(model.Location) ? record.Location : model.Location;
					record.Price = model.Price == null ? record.Price : model.Price;
					record.Type = string.IsNullOrEmpty(model.Type) ? record.Type : model.Type;
					record.NoOfRoom = model.NoOfRoom == null ? record.NoOfRoom : model.NoOfRoom;
					record.IsGated = model.IsGated == null ? record.IsGated : model.IsGated;
					record.Landmark = string.IsNullOrEmpty(model.Landmark) ? record.Landmark : model.Landmark;
					record.Description = string.IsNullOrEmpty(model.Description) ? record.Description : model.Description;
					record.ModifiedById = modifiedById;
					record.ModifiedDate = DateTime.Now;

					_unitOfWork.GetRepository<Rent>().Update(record);
					_unitOfWork.SaveChanges();

					return new BaseResponseModel
					{
						Status = true,
						Message = Response.Successful
					};
				}
				return new BaseResponseModel
				{
					Status = false,
					Message = Response.NotFound
				};
			}
			catch (Exception)
			{

				throw;
			}
		}
		public async Task<BaseResponseModel> UpdateStatus(RentApprovalViewModel model, Guid modifiedById)
		{

			try
			{
				var record = _unitOfWork.GetRepository<Rent>().GetFirstOrDefault(x => x.Id == model.Id, null, null, false);
				if (record != null)
				{
					record.ApprovalType = model.ApprovalType;
					record.ModifiedById = modifiedById;
					record.ModifiedDate = DateTime.Now;

					_unitOfWork.GetRepository<Rent>().Update(record);
					_unitOfWork.SaveChanges();

					return new BaseResponseModel
					{
						Status = true,
						Message = Response.Successful
					};
				}
				return new BaseResponseModel
				{
					Message = Response.NotFound
				};
			}
			catch (Exception)
			{
				return new BaseResponseModel
				{
					Message = Response.Failed
				};
			}
		}
	}
}
