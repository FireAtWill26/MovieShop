using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Services
{
    public class MovieService: IMovieService
    {
        private IMovieRepository _repository;
        public MovieService(IMovieRepository repo)
        {
            _repository = repo;
        }

        public int AddMovie(Movie movie)
        {
            return _repository.Insert(movie);
        }

        public int DeleteMovie(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Movie> GetAllMovie()
        {
            return _repository.GetAll();
        }

        public Movie GetMovieById(int id)
        {
            return _repository.GetById(id);
        }

        public int UpdateMovie(Movie movie, int id)
        {
            if (movie.Id == id)
            {
                return _repository.Update(movie);
            }
            return 0;
        }
    }
}
