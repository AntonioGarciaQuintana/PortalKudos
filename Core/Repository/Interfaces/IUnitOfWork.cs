﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
