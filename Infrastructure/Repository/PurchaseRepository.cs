using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class PurchaseRepository : BaseRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(MovieShopAppDbContext c) : base(c)
        {
        }
    }
}
