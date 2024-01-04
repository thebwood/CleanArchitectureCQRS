using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.ValueObjects.Users;

namespace CleanArchitectureCQRS.Application.Events
{
    public sealed record UserCreatedDomainEvent(UserId UserId) : IDomainEvent;
}
