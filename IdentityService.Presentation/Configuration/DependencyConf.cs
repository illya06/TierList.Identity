using IdentityService.Application;
using IdentityService.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.API.Configuration;

public static class DependencyConf
{
    public static IServiceCollection AddAuth(this IServiceCollection services)
    {
        services.AddAuthorization();
        services.AddAuthentication()
            .AddJwtBearer(IdentityConstants.BearerScheme);

        return services;
    }

    public static IServiceCollection AddMediatR(this IServiceCollection services)
    {
        services.AddMediatR(typeof(ApplicationAssemblyReference).Assembly);

        return services;
    }

    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen();

        return services;
    }

    public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR();
        services.AddSwagger();
        services.AddAuth();
        services.AddInfrastructure(configuration);

        return services;
    }
}
