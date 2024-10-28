using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class CastController : Controller
    {
        private readonly ICastService _castService;

        public CastController(ICastService castService)
        {
            _castService = castService;
        }

        public IActionResult Index(int page = 1)
        {
            ViewData["Page"] = page;
            var casts = _castService.GetAllCast();
            return View(casts.Skip(((int)ViewData["Page"]-1)*66).Take(66).ToList());
        }

        public IActionResult Detail(int Id)
        {
            Cast cast = _castService.GetCastById(Id);
            return View(cast);
        }
    }
}
