using Domain.AdsDataContext;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using DomainData.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainData
{
    class CategoryRepository : BaseRepository<CategoryItem, int, DataContext>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context)
        {

        }

        public async  Task<CategoryItem> Get(string categoryUrl)
        {
            CategoryItem result = await _dbContext.Categories.Where(x => x.CategoryUrl == categoryUrl).FirstOrDefaultAsync();
            return result;
        }

    }
}
