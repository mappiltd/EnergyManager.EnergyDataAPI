using System.Linq.Expressions;

namespace EnergyManager.EnergyDataAPI.Repositories
{
    public interface IRepository<TEntity>   
    {
        Task<int> AddAsync(TEntity entity);
        Task<int> AddRangeAsync(IEnumerable<TEntity> entities);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> GetAsync(Guid id);
        Task<ICollection<TEntity>> GetAllAsync();   
      
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        Task<bool> HasDataAsync(Expression<Func<TEntity, bool>> predicate);
        Task<int> RecordCountAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
