using IdentityService.Application.DTOs;
using IdentityService.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IJwtProvider _jwtProvider;

        public LoginCommandHandler(IJwtProvider jwtProvider)
        {
            _jwtProvider = jwtProvider;
        }

        Task<string> IRequestHandler<LoginCommand, string>.Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_jwtProvider.Generate(request.user));
        }
    }
}
