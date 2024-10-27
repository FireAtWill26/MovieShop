using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class CastController : Controller
    {
        private readonly ICastRepository _castRepository;

        public CastController(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }

        public IActionResult Index()
        {
            var casts = _castRepository.GetAll();
            return View(casts.Take(66).ToList());
        }

        public IActionResult Detail(int Id)
        {
            Cast cast = _castRepository.GetById(Id);
            return View(cast);
        }
    }
}
