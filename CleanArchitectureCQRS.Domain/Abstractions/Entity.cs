using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Abstractions
{
    public abstract class Entity
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        protected Entity(Guid id) { 
            Id = id;
        }
        public Guid Id { get; init; }

        public IReadOnlyList<IDomainEvent> GetDomainEvents => _domainEvents;
        public void AddDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
        public void RemoveDomainEvent(IDomainEvent domainEvent) => _domainEvents.Remove(domainEvent);

        public void ClearDomainEvents() => _domainEvents.Clear();

    }
}
