
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieServiceAsync _movieService;
        private readonly IGenreServiceAsync _genreService;

        public MovieController(IMovieServiceAsync movieService, IGenreServiceAsync genreService)
        {
            _movieService = movieService;
            _genreService = genreService;
        }

        public async Task<IActionResult> Index(string sort="Id", int page=1)
        {
            ViewData["sort"] = sort;
            ViewData["page"] = page;
            ViewBag.Genre = await _genreService.GetAllGenre();
            var result = await _movieService.GetAllMovie(sort, page, 64);
            return View(result);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Movie movie = await _movieService.GetMovieById(id);
            return View(movie);
        }

        public async Task<IActionResult> MoviesByGenre(int id, int pageSize = 50, int pageNumber = 1)
        {
            ViewData["id"] = id;
            ViewData["pageNumber"] = pageNumber;
            IEnumerable<Movie> movies = await _movieService.GetMoviesByGenre(id, pageSize, pageNumber);
            return View(movies);
        }
    }
}
