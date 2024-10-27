using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
