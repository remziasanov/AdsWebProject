using Domain.AdsDataContext;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using DomainData.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainData.Repositories
{
    public class CommentRepository : BaseRepository<Comment, int, DataContext>, ICommentRepository
    {
        public CommentRepository(DataContext dbContext) : base(dbContext)
        {

        }
    }
}
