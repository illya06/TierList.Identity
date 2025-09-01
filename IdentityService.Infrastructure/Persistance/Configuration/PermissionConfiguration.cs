using IdentityService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.Infrastructure.Persistance.Configuration;

class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Name).IsRequired();

        var roles = Enum.GetValues<Domain.Enums.Permission>()
            .Select(p => new Role
            {
                Id = (int)p,
                Name = p.ToString()
            });

        builder.HasData(roles);
    }
}

