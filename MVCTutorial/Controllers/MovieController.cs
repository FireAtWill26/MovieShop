
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieServiceAsync _movieService;

        public MovieController(IMovieServiceAsync movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Index(string sort="Id", int page=1)
        {
            ViewData["sort"] = sort;
            ViewData["page"] = page;
            object result;
            result = await _movieService.GetAllMovie(sort, page, 64);
            return View(result);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Movie movie = await _movieService.GetMovieById(id);
            return View(movie);
        }
    }
}
