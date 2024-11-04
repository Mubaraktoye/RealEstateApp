using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Model.ViewModel.Requests;
using RealEstateApp.Services.Interfaces;
using RealEstateApp.Web.Models;
using System.Diagnostics;

namespace RealEstateApp.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
		{ 
			return View();
		}

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

        [Route("RegisterUser")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> RegisterUser( string firstname, string lastname, string email, string phonenumber, string password)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var response = await _userService.CreateUser(new UserRequestViewModel 
                    {
                        FirstName = firstname,
                        LastName = lastname,
                        Email = email,
                        PhoneNumber = phonenumber,
                        Password = password
                    });

                    return Json(new
                    {
                        status = response.Status,
                        message = response.Message
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


        //[Route("LoginUser")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> LoginUser(string email, string password)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = await _userService.LoginUser(new UserLoginViewModel
                    {
                        Email = email,
                        Password = password
                    });
                    //if (response.Status)
                    //{
                    //    return RedirectToAction("Index", "Property");
                    //}
                    return Json(new
                    {
                        status = response.Status,
                        message = response.Message
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
