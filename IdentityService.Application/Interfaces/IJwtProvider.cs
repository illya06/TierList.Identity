using IdentityService.Domain.Models;

namespace IdentityService.Application.Interfaces;

public interface IJwtProvider
{
    public string Generate(User user);
}

