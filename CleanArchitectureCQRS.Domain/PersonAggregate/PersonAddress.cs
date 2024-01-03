using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.AddressAggregate;
using CleanArchitectureCQRS.Domain.ValueObjects.People;

namespace CleanArchitectureCQRS.Domain.PersonAggregate
{
    public class PersonAddress : AggregateRoot<PersonAddressId>
    {
        public PersonAddress(PersonAddressId id, Person person, Address address) 
            : base(id)
        {
            Person = person;
            Address = address;
        }

        public Person Person { get; private set; }
        public Address Address { get; private set; }
    }
}
