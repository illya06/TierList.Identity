using IdentityService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.Infrastructure.Persistance.Contexts;

interface IIdentityServiceDbContext
{
    DbSet<User> Users { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

