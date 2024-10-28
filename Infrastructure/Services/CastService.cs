using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class CastService: ICastService
    {
        private ICastRepository _repository;
        public CastService(ICastRepository repo)
        {
            _repository = repo;
        }

        public int AddCast(Cast cast)
        {
            return _repository.Insert(cast);
        }

        public int DeleteCast(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Cast> GetAllCast()
        {
            return _repository.GetAll();
        }

        public Cast GetCastById(int id)
        {
            return _repository.GetById(id);
        }

        public int UpdateCast(Cast cast, int id)
        {
            if (cast.Id == id)
            {
                return _repository.Update(cast);
            }
            return 0;
        }
        public IEnumerable<Cast> GetCastsWithMovie()
        {
            return _repository.GetCastsWithMovie();
        }
    }
}
