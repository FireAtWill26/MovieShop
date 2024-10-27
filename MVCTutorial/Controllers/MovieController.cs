
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            var result = _movieRepository.GetMostRecentMovies(64);
            return View(result);
        }

        public IActionResult Detail(int id)
        {
            Movie movie = _movieRepository.GetMoviebyId(id);
            return View(movie);
        }
    }
}
