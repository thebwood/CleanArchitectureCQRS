using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.People;

namespace CleanArchitectureCQRS.Domain.PersonAggregate
{
    public sealed class Person : AggregateRoot
    {
        public Person(Guid id, PersonDetail detail)
            : base(id)
        {
            Detail = detail;
        }

        public PersonDetail Detail { get; private set; }
    }
}
