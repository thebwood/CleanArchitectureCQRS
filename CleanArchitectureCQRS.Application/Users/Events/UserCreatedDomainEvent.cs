using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Users.Events
{
    public sealed record UserCreatedDomainEvent(UserId UserId) : IDomainEvent;
}
