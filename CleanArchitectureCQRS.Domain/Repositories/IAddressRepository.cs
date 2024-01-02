using CleanArchitectureCQRS.Domain.AddressAggregate;

namespace CleanArchitectureCQRS.Domain.Repositories
{
    public interface IAddressRepository
    {
        Task<Address?> GetById(Guid id, CancellationToken cancellationToken = default);
        void Add(Address address);
    }
}
