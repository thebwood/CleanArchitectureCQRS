using CleanArchitectureCQRS.Domain.Addresses;

namespace CleanArchitectureCQRS.Domain.Repositories
{
    public interface IAddressRepository
    {
        void Add(Address address);
        void Remove(Address address);
    }
}
