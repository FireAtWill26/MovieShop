using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Services
{
    public class MovieService: IMovieService
    {
        private IGenreRepository _repository;
        public MovieService(IGenreRepository repo)
        {
            _repository = repo;
        }

        public int AddGenre(Genre genre)
        {
            return _repository.Insert(genre);
        }

        public int DeleteGenre(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Genre> GetAllGenre()
        {
            return _repository.GetAll();
        }

        public Genre GetGenreById(int id)
        {
            return _repository.GetById(id);
        }

        public int UpdateGenre(Genre genre, int id)
        {
            if (genre.Id == id)
            {
                return _repository.Update(genre);
            }
            return 0;
        }
    }
}
