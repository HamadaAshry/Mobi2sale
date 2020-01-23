using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Interfaces.Persistence
{
    public interface IGenericRepository<TEntity>:IDisposable where TEntity:class 
    {
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entites);       
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entites);
        Task<TEntity> ReloadAsync(TEntity entity);
        Task<TEntity> GetAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filterPredicate);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filterPredicate, Expression<Func<TEntity, dynamic>> selector);
    }
}