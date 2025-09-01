using IdentityService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.Infrastructure.Persistance.Configuration;

class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
{
    public void Configure(EntityTypeBuilder<RolePermission> builder)
    {
        builder.HasKey(rp => new { rp.RoleId, rp.PermissionId });

        builder.HasData(
            Create(Domain.Enums.Role.Guest, Domain.Enums.Permission.ReadMember),
            Create(Domain.Enums.Role.User, Domain.Enums.Permission.UpdateMember),
            Create(Domain.Enums.Role.User, Domain.Enums.Permission.ReadMember));
    }

    private static RolePermission Create(Domain.Enums.Role role, Domain.Enums.Permission permission)
    {
        return new RolePermission
        {
            RoleId = (int) role,
            PermissionId = (int) permission
        };
    }
}

