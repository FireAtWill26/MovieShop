using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface IGenreService
    {
        int AddGenre(Genre genre);
        int UpdateGenre(Genre genre, int id);
        int DeleteGenre(int id);
        IEnumerable<Genre> GetAllGenre();
        Genre GetGenreById(int id);
    }
}
