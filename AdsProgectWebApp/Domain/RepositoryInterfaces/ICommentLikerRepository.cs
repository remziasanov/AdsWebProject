using Domain.Entities;
using Domain.RepositoryInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryInterfaces
{
    public interface ICommentLikerRepository : IRepositoryBase<CommentLiker, int>
    {
        bool AddLike(int commentId, Guid userId);
        bool DeleteLike(int commentId, Guid userId);
    }
}
