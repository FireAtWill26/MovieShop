using ApplicationCore.Contracts.Repository;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly MovieShopAppDbContext _context;

        public BaseRepository(MovieShopAppDbContext c) {
            _context = c;
        }

        public int Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null)
            {
                return 0;
            }
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int GetCount(Expression<Func<T, bool>> filter = null)
        {
            if(filter == null)
            {
                return _context.Set<T>().Count();
            }
            return _context.Set<T>().Where(filter).Count();
        }

        public int Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
