﻿
using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Users.Events;

namespace CleanArchitectureCQRS.Domain.Users
{
    public sealed class User : Entity
    {
        public User(Guid id, FirstName firstName, LastName lastName, Email email) 
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }
        public Email Email { get; private set; }

        public static User Create(FirstName firstName, LastName lastName, Email email)
        {
            var user = new User(Guid.NewGuid(), firstName, lastName, email);
            user.AddDomainEvent(new UserCreatedDomainEvent(user.Id));
            return user;
        }
    }
}
