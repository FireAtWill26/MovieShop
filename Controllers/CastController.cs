using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class CastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
