﻿using CleanArchitectureCQRS.Domain.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        Task<int> GetById(Guid id, CancellationToken cancellationToken = default);
        void Add(User user);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
