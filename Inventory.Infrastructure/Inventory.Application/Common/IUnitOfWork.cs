﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Abstractions.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<T> GetReposiotory<T>() where T : class;
        Task<int> CompleteAsync();

    }
}
