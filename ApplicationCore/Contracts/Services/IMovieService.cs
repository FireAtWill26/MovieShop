using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface IMovieService
    {
        int AddMovie(Movie movie);

        int DeleteMovie(int id);

        IEnumerable<Movie> GetAllMovie();

        Movie GetMovieById(int id);

        int UpdateMovie(Movie movie, int id);

        IEnumerable<Movie> GetMoviesWithGenreAndCast();
    }
}
