using IdentityService.Domain.Models;
using IdentityService.Infrastructure.Persistance.Configuration;
using IdentityService.Infrastructure.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.Infrastructure.Persistence.Contexts;

public class IdentityServiceDbContext : DbContext, IIdentityServiceDbContext
{
    public DbSet<User> Users => Set<User>();

    public IdentityServiceDbContext(DbContextOptions<IdentityServiceDbContext> options)
        : base(options) {}

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.ApplyConfiguration(new UserConfiguration());
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}
