using CleanArchitectureCQRS.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Abstractions
{
    public abstract class Entity<TEntityId> : IEntity
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        protected Entity(TEntityId id)
        {
            Id = id;
        }
        public TEntityId Id { get; init; }

        public IReadOnlyList<IDomainEvent> GetDomainEvents() => _domainEvents;
        public void AddDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
        public void RemoveDomainEvent(IDomainEvent domainEvent) => _domainEvents.Remove(domainEvent);

        public void ClearDomainEvents() => _domainEvents.Clear();

    }
}
