using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Users;
using CleanArchitectureCQRS.Domain.Users.Events;
using CleanArchitectureCQRS.Domain.ValueObjects.People;
using CleanArchitectureCQRS.Domain.ValueObjects.Users;

namespace CleanArchitectureCQRS.Domain.UserAggregate
{
    public sealed class User : AggregateRoot<UserId>
    {
        private User(UserId id, FirstName firstName, LastName lastName, Email email)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public FirstName FirstName { get; private set; }

        public LastName LastName { get; private set; }

        public Email Email { get; private set; }

        public string IdentityId { get; private set; } = string.Empty;

        public static User Create(FirstName firstName, LastName lastName, Email email)
        {
            var user = new User(UserId.New(), firstName, lastName, email);

            user.AddDomainEvent(new UserCreatedDomainEvent(user.Id.Value));

            return user;
        }

        public void SetIdentityId(string identityId)
        {
            IdentityId = identityId;
        }
    }
}
