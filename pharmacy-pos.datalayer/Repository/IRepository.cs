using System.Linq.Expressions;

namespace pharmacy_pos.datalayer.Repository
{
    public interface IRepository<T>: IDisposable where T : class
    {
        Task<T> Get(string id);
        Task<T> Find(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdatedRange(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        Task Save();

    }
}
