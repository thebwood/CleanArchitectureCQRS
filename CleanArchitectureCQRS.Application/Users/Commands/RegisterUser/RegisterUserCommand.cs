using CleanArchitectureCQRS.Application.Abstractions.Messaging;

namespace CleanArchitectureCQRS.Application.Users.Commands.RegisterUser
{
    public sealed record RegisterUserCommand(
            string Email,
            string FirstName,
            string LastName,
            string Password) : ICommand<Guid>;
}
