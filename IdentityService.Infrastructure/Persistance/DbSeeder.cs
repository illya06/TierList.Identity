using IdentityService.Domain.Models;
using IdentityService.Infrastructure.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.Infrastructure.Persistence;

public static class DbSeeder
{
    public static async Task SeedAsync(IIdentityServiceDbContext context)
    {
        if (!await context.Users.AnyAsync())
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = "admin",
                Email = "admin@example.com"
            };

            context.Users.Add(user);
            await context.SaveChangesAsync();
        }
    }
}