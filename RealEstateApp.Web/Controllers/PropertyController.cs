using AutoMapper.Execution;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateApp.Core.Helper;
using RealEstateApp.Model.Enum;
using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Services.Interfaces;
using RealEstateApp.Web.Models;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;

namespace RealEstateApp.Web.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPurchaseService _purchaseService;
        private readonly IRentService _rentService;
        private readonly IPictureService _pictureService;

        public PropertyController(
            IPurchaseService purchaseService,
            IRentService rentService,
            IPictureService pictureService)
        {
            _purchaseService = purchaseService;
            _rentService = rentService;
            _pictureService = pictureService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public async Task<IActionResult> Add()
        {
            
            return View();
        }

        [Route("AddProperty")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> AddProperty(PropertyClientRequestModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var propertyRefId = Guid.NewGuid();
                    List<string> pictures = new List<string>();
                    //upload the pictures
                    foreach (var item in model.PropertyPics)
                    {
                        var path = $"wwwroot/Uploads/Documents/Property/{Guid.NewGuid()}/";
                        var uploadUrl = await FileUpload.UploadFile(item, null, false, path);
                        pictures.Add(uploadUrl);

                        PictureType type = model.PropertyType == 1 ? PictureType.RentPic : PictureType.PurchasePic;
                        await _pictureService.CreatePicture(type, propertyRefId, uploadUrl);
                    }

                    if (model.PropertyType == 1)
                    {
                        var response = await _rentService.CreateRent(new RentRequestViewModel
                        {
                            Id = propertyRefId,
                            Type = model.PropertyTitle,
                            Location = model.PropertyLocation,
                            Landmark = model.PropertyLandmark,
                            Description = model.PropertyDescription,
                            NoOfRoom = model.PropertyRooms,
                            IsGated = model.PropertyGated,
                            Status = "Open",
                            Price = model.PropertyPrice

                        }, Guid.Parse("A2B826DC-88CF-415C-8E07-08DCFCC05438"));

                        return Json(new
                        {
                            status = response.Status,
                            message = response.Message
                        });
                    }

                    return Json(new
                    {
                        status = true,
                        message = "Request submitted successfully"
                    });
                }
                return Json(new
                {
                    status = false,
                    message = "Error with Current Request"
                });
            }
            catch (Exception ex)
            {
                return Json(new { });
                //return ErrorPage(ex);
            }
        }

    }
}
