using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Contracts.Repository
{
    public interface IMovieRepository: IRepository<Movie>
    {
        Movie GetHighestGrossingMovies();

        Movie GetMoviebyId(int movieId);

        string GetMovieDetails(int movieId);

        IEnumerable<Movie> GetMoviesWithGenreAndCast();
        IEnumerable<Movie> GetMostRecentMovies(int number = 20);
    }
}
