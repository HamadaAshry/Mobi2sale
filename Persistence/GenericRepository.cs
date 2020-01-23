using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>where TEntity : class
    {
         private readonly DbSet<TEntity> _dbSet;
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context=context;
            _dbSet=_context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entites)
        {
            await  _dbSet.AddRangeAsync(entites);
        }

        public void Dispose()
        {
          _context.Dispose();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filterPredicate)
        {
            return await _dbSet.Where(filterPredicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filterPredicate, Expression<Func<TEntity, dynamic>> selector)
        {
            return await _dbSet.Where(filterPredicate).Include(selector).ToListAsync();        }

        public async Task<TEntity> GetAsync(Guid id)
        {
           return await _dbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
             return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> ReloadAsync(TEntity entity)
        {
            await _context.Entry(entity).ReloadAsync();
            return entity;
        }

        public void Remove(TEntity entity)
        {
           _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entites)
        {
           _dbSet.RemoveRange(entites);
        }
      
    }
}