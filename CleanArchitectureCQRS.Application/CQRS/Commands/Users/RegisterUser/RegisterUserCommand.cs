using CleanArchitectureCQRS.Application.Abstractions.Messaging;

namespace CleanArchitectureCQRS.Application.CQRS.Commands.Users.RegisterUser
{
    public sealed record RegisterUserCommand(
            string Email,
            string FirstName,
            string LastName,
            string Password) : ICommand<Guid>;
}
