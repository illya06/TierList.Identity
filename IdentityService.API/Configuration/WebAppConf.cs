using IdentityService.Infrastructure.Persistance.Contexts;
using IdentityService.Infrastructure.Persistence;

namespace IdentityService.API.Configuration
{
    public static class WebAppConf
    {
        public static async Task<WebApplication> MigrateAndSeedDatabaseAsync(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<IIdentityServiceDbContext>();
                await db.MigrateAsync();
                await DbSeeder.SeedAsync(db);
            }

            return app;
        }
    }
}
