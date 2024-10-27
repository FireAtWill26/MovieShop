using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class CastRepository : BaseRepository<Cast>, ICastRepository
    {
        private readonly MovieShopAppDbContext _context;
        public CastRepository(MovieShopAppDbContext c) : base(c)
        {
            _context = c;
        }

        public IEnumerable<Cast> GetCastsWithMovie()
        {
            return _context.Casts.Include(x => x.MovieCasts).
                ThenInclude(mc => mc.Movie).ToList();
        }

        public Cast GetById(int Id)
        {
            foreach(Cast cast in GetCastsWithMovie())
            {
                if(cast.Id == Id)
                {
                    return cast;
                }
            }
            return null;
        }


    }
}
