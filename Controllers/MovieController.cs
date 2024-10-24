
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
