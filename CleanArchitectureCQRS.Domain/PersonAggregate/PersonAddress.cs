using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.AddressAggregate;

namespace CleanArchitectureCQRS.Domain.PersonAggregate
{
    public class PersonAddress : AggregateRoot
    {
        public PersonAddress(Guid id) 
            : base(id)
        {
        }

        public Person Person { get; private set; }
        public Address Address { get; private set; }
    }
}
