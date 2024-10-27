using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
