using Domain.Entities;
using Domain.RepositoryInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryInterfaces
{
    public interface ICategoryRepository : IRepositoryBase<CategoryItem, int>
    {
        CategoryItem Get(string categoryName);
        void Detele(int id);
        CategoryItem Get(int id);
    }
}
