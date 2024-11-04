using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Approval()
        {
            return View();
        }

        [Route("Admin/Approve-Property")]
        public IActionResult RentApproval()
        {
            return View();
        }
    }
}


