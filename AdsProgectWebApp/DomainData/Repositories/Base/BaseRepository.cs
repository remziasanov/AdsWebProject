using Domain.AdsDataContext;
using Domain.Entities.Base;
using Domain.RepositoryInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainData.Repositories.Base
{
    public abstract class BaseRepository<T, TId> : IRepositoryBase<T, TId> where T : EntityBase<TId>
    {
        protected readonly DataContext _dbContext;
        public BaseRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TId Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        public virtual IQueryable<T> GetAll()
        {
            var result = _dbContext.Set<T>();
            return result;
        }

        public virtual IQueryable<T> GetLastEight()
        {
            var result = _dbContext.Set<T>();
            return result;
        }

        public T SaveOrUpdate(T entity)
        {
            throw new NotImplementedException();
        }

        public TId Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }
    }
}
