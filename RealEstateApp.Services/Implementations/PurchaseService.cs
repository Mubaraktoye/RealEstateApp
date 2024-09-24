using Arch.EntityFrameworkCore.UnitOfWork;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Core.Constants;
using RealEstateApp.Model.Data;
using RealEstateApp.Model.Enum;
using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;
using RealEstateApp.Services.Interfaces;

namespace RealEstateApp.Services.Implementations
{
	public class PurchaseService: IPurchaseService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public PurchaseService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		/// <summary>
		/// This a method for user to create Purchase property 
		/// </summary>
		/// <param name="model"> </param>
		/// <returns></returns>
		public async Task<BaseResponseModel> CreatePurchase(PurchaseRequestViewModel model, Guid createdBy)
		{
			try
			{
				Purchase PurchaseData = new Purchase
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
					Description = model.Description,
					Measurement =model.Measurement
				};
				await _unitOfWork.GetRepository<Purchase>().InsertAsync(PurchaseData);
				_unitOfWork.SaveChanges();

				return new BaseResponseModel
				{
					Status = true,
					Message = Response.Successful
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

		/// <summary>
		/// Get list of approved purchase
		/// </summary>
		/// <returns></returns>
		public async Task<PurchaseListResponseViewModel> GetApprovedPurchase()
		{
			try
			{
				var dataResponse = await _unitOfWork.GetRepository<Purchase>().GetAllAsync(x => x.ApprovalType == ApprovalType.Approved, orderBy: source => source.OrderBy(c => c.Id), "CreatedBy"); //to be optimized on entity framework core extention
				var mappedResponse = _mapper.Map<List<PurchaseResponse>>(dataResponse);

				return new PurchaseListResponseViewModel
				{
					Status = true,
					Message = Response.Successful,
					Data = mappedResponse
				};
			}
			catch (Exception)
			{

			}
			return new PurchaseListResponseViewModel
			{
				Status = false,
				Message = Response.Failed
			};
		}

		/// <summary>
		/// Get purchase by id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public async Task<PurchaseResponseViewModel> GetPurchaseById(Guid id)
		{
			try
			{
				var dataResponse = _unitOfWork.GetRepository<Purchase>().GetFirstOrDefault(x => x.Id == id, null, null, false);
				var mappedResponse = _mapper.Map<PurchaseResponse>(dataResponse);

				return new PurchaseResponseViewModel
				{
					Status = true,
					Message = Response.Successful,
					Data = mappedResponse
				};
			}
			catch (Exception)
			{

			}
			return new PurchaseResponseViewModel
			{
				Status = false,
				Message = Response.Failed
			};
		}

		public async Task<PurchaseResponseViewModel> GetPurchaseByUser(Guid user)
		{
			try
			{
				var dataResponse = _unitOfWork.GetRepository<Purchase>().GetFirstOrDefault(x => x.CreatedById == user, null, null, false);
				var mappedResponse = _mapper.Map<PurchaseResponse>(dataResponse);

				return new PurchaseResponseViewModel
				{
					Status = true,
					Message = Response.Successful,
					Data = mappedResponse
				};
			}
			catch (Exception)
			{

			}
			return new PurchaseResponseViewModel
			{
				Status = false,
				Message = Response.Failed
			};
		}

		public async Task<BaseResponseModel> UpdatePurchase(PurchaseUpdateViewModel model, Guid modifiedById)
		{
			try
			{
				var record = _unitOfWork.GetRepository<Purchase>().GetFirstOrDefault(x => x.Id == model.Id, null, null, false);

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

					_unitOfWork.GetRepository<Purchase>().Update(record);
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

		public async Task<BaseResponseModel> UpdateStatus(PurchaseApprovalViewModel model, Guid modifiedById)
		{

			try
			{
				var record = _unitOfWork.GetRepository<Purchase>().GetFirstOrDefault(x => x.Id == model.Id, null, null, false);
				if (record != null)
				{
					record.ApprovalType = model.ApprovalType;
					record.ModifiedById = modifiedById;
					record.ModifiedDate = DateTime.Now;

					_unitOfWork.GetRepository<Purchase>().Update(record);
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
