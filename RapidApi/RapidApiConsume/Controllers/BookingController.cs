using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsume.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
