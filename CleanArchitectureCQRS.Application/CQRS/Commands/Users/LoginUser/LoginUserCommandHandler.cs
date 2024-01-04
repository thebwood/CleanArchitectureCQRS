﻿using CleanArchitectureCQRS.Application.Abstractions.Authentication;
using CleanArchitectureCQRS.Application.Abstractions.Messaging;
using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Users;

namespace CleanArchitectureCQRS.Application.CQRS.Commands.Users.LoginUser
{
    internal sealed class LoginUserCommandHandler : ICommandHandler<LoginUserCommand, AccessTokenResponse>
    {
        private readonly IJwtService _jwtService;

        public LoginUserCommandHandler(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        public async Task<Result<AccessTokenResponse>> Handle(
            LoginUserCommand request,
            CancellationToken cancellationToken)
        {
            var result = await _jwtService.GetAccessTokenAsync(
                request.Email,
                request.Password,
                cancellationToken);

            if (result.IsFailure)
            {
                return Result.Failure<AccessTokenResponse>(UserErrors.InvalidCredentials);
            }

            return new AccessTokenResponse(result.Value);
        }
    }
}
