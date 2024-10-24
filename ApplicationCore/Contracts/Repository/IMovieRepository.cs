using MVCTutorial.Entities;

namespace MVCTutorial.ApplicationCore.Contracts.Repository
{
    public interface IMovieRepository<T>
    {
        T GetHighestGrossingMovies();

        Movie GetMoviebyId(int movieId);

        string GetMovieDetails(int movieId);
    }
}
