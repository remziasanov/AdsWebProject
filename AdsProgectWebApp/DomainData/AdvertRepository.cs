using Domain.AdsDataContext;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using DomainData.Repositories.Base;
using System;

namespace DomainData
{
    public class AdvertRepository : BaseRepository<Advert, Guid, DataContext>, IAdvertRepository
    {
        public AdvertRepository(DataContext dbcontext) : base(dbcontext)
        {

        }
    }
}
