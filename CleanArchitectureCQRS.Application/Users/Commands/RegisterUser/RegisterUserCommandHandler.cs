using CleanArchitectureCQRS.Application.Abstractions.Authentication;
using CleanArchitectureCQRS.Application.Abstractions.Messaging;
using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Common.ValueObjects;
using CleanArchitectureCQRS.Domain.UserAggregate;
using CleanArchitectureCQRS.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Users.Commands.RegisterUser
{
    internal sealed class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand, Guid>
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterUserCommandHandler(
            IAuthenticationService authenticationService,
            IUserRepository userRepository,
            IUnitOfWork unitOfWork)
        {
            _authenticationService = authenticationService;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<Guid>> Handle(
            RegisterUserCommand request,
            CancellationToken cancellationToken)
        {
            var user = User.Create(

                new Name(
                new FirstName(request.FirstName),
                new LastName(request.LastName)),
                new Email(request.Email));

            var identityId = await _authenticationService.RegisterAsync(
                user,
                request.Password,
                cancellationToken);

            user.SetIdentityId(identityId);

            _userRepository.Add(user);

            await _unitOfWork.SaveChangesAsync();

            return user.Id.Value;
        }
    }
}
