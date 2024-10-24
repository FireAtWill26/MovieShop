using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
