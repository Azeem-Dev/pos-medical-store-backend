using Microsoft.EntityFrameworkCore;
using pharmacy_pos.ef.Data;
using System.Linq.Expressions;

namespace pharmacy_pos.datalayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
        public async Task<T> Find(Expression<Func<T, bool>> predicate)
            => await _context.Set<T>().FirstOrDefaultAsync(predicate);

        public async Task<T> Get(string id)
            => await _context.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> GetAll()
            => await _context.Set<T>().ToListAsync();

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
            => await _context.Set<T>().Where(predicate).ToListAsync();

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void UpdatedRange(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
