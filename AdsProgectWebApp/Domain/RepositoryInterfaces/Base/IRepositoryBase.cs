using Domain.Entities;
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces.Base
{
    public interface IRepositoryBase<T, TId> where T : EntityWithTypedIdBase<TId>
    {
        IQueryable<T> GetAll();
        TId Create(T entity);
        TId Update(T entity);
    }
}
