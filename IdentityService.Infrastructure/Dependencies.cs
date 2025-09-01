using IdentityService.Application.Interfaces;
using IdentityService.Infrastructure.Auth;
using IdentityService.Infrastructure.Persistance.Contexts;
using IdentityService.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityService.Infrastructure;
public static class Dependencies
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IJwtProvider, JwtProvider>();

        services.AddDbContext<IIdentityServiceDbContext, IdentityServiceDbContext>(
                opt => opt.UseNpgsql(configuration.GetConnectionString("IdentityConnection")));
            
        return services;
    }
}