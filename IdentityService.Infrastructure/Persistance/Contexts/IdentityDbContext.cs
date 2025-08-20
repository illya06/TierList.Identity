using Microsoft.EntityFrameworkCore;

namespace IdentityService.Infrastructure.Persistence.Contexts;

public class IdentityServiceDbContext : DbContext
{
    public IdentityServiceDbContext(DbContextOptions<IdentityServiceDbContext> options)
        : base(options)
    {
    }


}
