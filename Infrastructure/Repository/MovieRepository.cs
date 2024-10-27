using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infrastructure.Repository
{
    public class MovieRepository: BaseRepository<Movie>, IMovieRepository
    {
        private readonly MovieShopAppDbContext _context;
        
        public MovieRepository(MovieShopAppDbContext c) : base(c)
        {
            _context = c;
        }

        public Movie GetHighestGrossingMovies()
        {
            throw new NotImplementedException();
        }

        public Movie GetMoviebyId(int movieId)
        {
            return GetMoviesWithGenreAndCast().FirstOrDefault(x => x.Id == movieId);
        }

        public string GetMovieDetails(int movieId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMoviesWithGenreAndCast()
        {
            return _context.Movies.
                Include(x => x.MovieGenres).ThenInclude(mg => mg.Genre).
                Include(x => x.MovieCasts).ThenInclude(mc => mc.Cast).
                Include(x => x.Trailers).ToList();
        }

        public IEnumerable<Movie> GetMostRecentMovies(int number = 20)
        {
            return GetAll().OrderByDescending(x => x.ReleaseDate).Take(number).ToList(); ;
        }

    }
}
