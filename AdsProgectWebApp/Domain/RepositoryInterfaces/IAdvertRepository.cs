﻿using Domain.Entities;
using Domain.RepositoryInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryInterfaces
{
    public interface IAdvertRepository : IRepositoryBase<Advert, Guid>
    {
        void Delete(Guid id);
        Advert Get(Guid id);
    }
}
