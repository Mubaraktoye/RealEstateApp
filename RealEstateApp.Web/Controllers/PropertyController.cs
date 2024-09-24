using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Web.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
