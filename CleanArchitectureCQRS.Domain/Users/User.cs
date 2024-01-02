
using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Common.ValueObjects;
using CleanArchitectureCQRS.Domain.Users.Events;

namespace CleanArchitectureCQRS.Domain.Users
{
    public sealed class User : Entity
    {
        public User(Guid id, Name name, Email email)
            : base(id)
        {
            Name = Name;
            Email = email;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }

        public static User Create(Name name, Email email)
        {
            var user = new User(Guid.NewGuid(), name, email);
            user.AddDomainEvent(new UserCreatedDomainEvent(user.Id));
            return user;
        }
    }
}
