using EnergyManager.EnergyDataAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq.Expressions;


namespace EnergyManager.EnergyDataAPI.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private TEntity NewEntity => Activator.CreateInstance<TEntity>();

        protected readonly IDbContextFactory<ApplicationDbContext> _applicationContext;

        public Repository(IDbContextFactory<ApplicationDbContext> applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task<int> AddAsync(TEntity entity)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            await context.Set<TEntity>().AddAsync(entity);

            return await context.SaveChangesAsync();
        }

        public async Task<int> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            using var context = _applicationContext.CreateDbContext();
            await context.Set<TEntity>().AddRangeAsync(entities);

            return await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using var context = _applicationContext.CreateDbContext();
            List<TEntity> items = await context.Set<TEntity>().Where(predicate).ToListAsync();

            return items;
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            return await context.Set<TEntity>().FindAsync(id) ?? NewEntity;
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            return await context.Set<TEntity>().ToListAsync();
        }      

        public void Remove(TEntity entity)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            context.Set<TEntity>().Remove(entity);              
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            context.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            context.Set<TEntity>().Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            context.Set<TEntity>().UpdateRange(entities);
        }

        public async Task<bool> HasDataAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();

            return await context.Set<TEntity>().Where(predicate).AnyAsync();    
        }

        public async Task<int> RecordCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();

            return await context.Set<TEntity>().Where(predicate).CountAsync();
        }
    }
}
