﻿using Domain.Entities;
using Domain.RepositoryInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryInterfaces
{
    public interface ICommentRepository : IRepositoryBase<Comment, int>
    {

    }
}
