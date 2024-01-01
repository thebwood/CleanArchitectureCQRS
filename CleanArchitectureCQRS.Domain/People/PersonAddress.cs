using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Addresses;

namespace CleanArchitectureCQRS.Domain.People
{
    public class PersonAddress : Entity
    {
        public PersonAddress(Guid id) : base(id)
        {
        }

        public Person Person { get; private set; }
        public Address Address { get; private set; }
    }
}
