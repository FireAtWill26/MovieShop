using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface ICastService
    {
        int AddCast(Cast cast);

        int DeleteCast(int id);

        IEnumerable<Cast> GetAllCast();
        Cast GetCastById(int id);

        int UpdateCast(Cast cast, int id);

        IEnumerable<Cast> GetCastsWithMovie();
    }
}
