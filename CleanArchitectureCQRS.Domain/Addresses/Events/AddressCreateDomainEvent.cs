
using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.ValueObjects.Addresses;

namespace CleanArchitectureCQRS.Domain.Addresses.Events
{
    public sealed record AddressCreateDomainEvent(AddressId AddressId) : IDomainEvent;
}
