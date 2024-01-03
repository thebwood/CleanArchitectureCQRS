using CleanArchitectureCQRS.Domain.AddressAggregate;
using CleanArchitectureCQRS.Domain.ValueObjects.Addresses;

namespace CleanArchitectureCQRS.Domain.Abstractions.Repositories
{
    public interface IAddressRepository
    {
        Task<Address?> GetById(AddressId id, CancellationToken cancellationToken = default);
        void Add(Address address);
    }
}
