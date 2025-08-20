using IdentityService.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, UserDto>
    {
        Task<UserDto> IRequestHandler<LoginCommand, UserDto>.Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new UserDto()
            {
                Email = request.user.Email,
                PasswordHash = request.user.PasswordHash,
                Username = "egsvfd"
            });
        }
    }
}
