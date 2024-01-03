using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.People;
using CleanArchitectureCQRS.Domain.ValueObjects.People;

namespace CleanArchitectureCQRS.Domain.PersonAggregate
{
    public sealed class Person : AggregateRoot<PersonId>
    {
        public Person(PersonId id, PersonDetail detail)
            : base(id)
        {
            Detail = detail;
        }

        public PersonDetail Detail { get; private set; }
    }
}
