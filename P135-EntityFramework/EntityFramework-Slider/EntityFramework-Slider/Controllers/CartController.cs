using Microsoft.AspNetCore.Mvc;

namespace EntityFramework_Slider.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
