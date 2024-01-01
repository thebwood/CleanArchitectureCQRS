
using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Addresses;

namespace CleanArchitectureCQRS.Domain.People
{
    public sealed class Person : Entity
    {
        public Person(Guid id, PersonDetail detail, Address address) 
            : base(id)
        {
            Detail = detail;
            Address = address;
        }

        public PersonDetail Detail { get; private set; }
        public Address Address { get; private set; }
    }
}
