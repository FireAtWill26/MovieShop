using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
