using IdentityService.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityService.Application;
public static class Dependencies
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        return services;
    }
}