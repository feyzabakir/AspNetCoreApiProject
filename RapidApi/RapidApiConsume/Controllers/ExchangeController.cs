using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsume.Controllers
{
    public class ExchangeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
