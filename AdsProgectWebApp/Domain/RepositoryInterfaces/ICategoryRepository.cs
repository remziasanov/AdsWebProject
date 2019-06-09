using Domain.Entities;
using Domain.RepositoryInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface ICategoryRepository : IRepositoryBase<CategoryItem, int>
    {
        /// <summary>
        /// Получение категории по названию
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        Task<CategoryItem> Get(string categoryName);
    }
}
