using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Model.ViewModel.Responses;
using RealEstateApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Services.Interfaces
{
    public interface IPurchaseService
    {
        Task<BaseResponseModel> CreatePurchase(PurchaseRequestViewModel model, Guid createdBy);
    }
}