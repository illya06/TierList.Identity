using IdentityService.Domain.Enums;
using Microsoft.AspNetCore.Authorization;

namespace IdentityService.Infrastructure.Auth;

class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(Permission permission)
        : base(policy: permission.ToString())
    {
        
    }
}
