﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Users
{
    public interface IUserRepository
    {
        Task<User?> GetById(Guid id, CancellationToken cancellationToken = default);
        void Add(User user);
    }
}
