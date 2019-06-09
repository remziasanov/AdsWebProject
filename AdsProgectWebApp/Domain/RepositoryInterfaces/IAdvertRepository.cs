using Domain.Entities;
using Domain.RepositoryInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryInterfaces
{
    /// <summary>
    /// Репозиторий для объявлений
    /// </summary>
    public interface IAdvertRepository : IRepositoryBase<Advert, Guid>
    {
        // для дополнительных методов для работы с объявлениями
    }
}
