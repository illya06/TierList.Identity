using IdentityService.Application.DTOs;
using IdentityService.Domain.Models;
using MediatR;

namespace IdentityService.Application.Login;

public record LoginCommand(User user) : IRequest<string>;