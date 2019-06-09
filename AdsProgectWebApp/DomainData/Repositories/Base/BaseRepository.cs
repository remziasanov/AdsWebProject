using Domain.AdsDataContext;
using Domain.Entities.Base;
using Domain.RepositoryInterfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainData.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TId, TContext> : IRepositoryBase<TEntity, TId> 
        where TEntity : EntityBase<TId>
        where TContext : DbContext
    {
        protected readonly TContext _dbContext;

        public BaseRepository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Get(TId id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            var result = _dbContext.Set<TEntity>();
            return result;
        }

        public async Task<TEntity> Delete(TId id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
