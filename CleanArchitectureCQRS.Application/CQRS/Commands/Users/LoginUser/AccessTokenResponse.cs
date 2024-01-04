
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.CQRS.Commands.Users.LoginUser
{
    public sealed record AccessTokenResponse(string AccessToken);
}
