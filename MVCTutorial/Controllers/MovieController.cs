
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Index(string sort="Id", int page=1)
        {
            ViewData["sort"] = sort;
            ViewData["page"] = page;
            object result;
            if ((string)ViewData["sort"] == "Id")
            {
                result = _movieService.GetMoviesWithGenreAndCast().Skip(((int)ViewData["page"] - 1)*64).Take(64).ToList();
            }
            else
            {
                result = _movieService.GetMoviesWithGenreAndCast().OrderByDescending(x=>x.ReleaseDate).
                    Skip(((int)ViewData["page"] - 1) * 64).Take(64).ToList();
            }
            return View(result);
        }

        public IActionResult Detail(int id)
        {
            Movie movie = _movieService.GetMovieById(id);
            return View(movie);
        }
    }
}
