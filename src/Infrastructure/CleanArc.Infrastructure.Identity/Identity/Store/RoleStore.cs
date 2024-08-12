using CleanArc.Domain.Entities.User;
using CleanArc.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Identity.Identity.Store;

public class RoleStore:RoleStore<Role,ApplicationDbContext,long,UserRole,RoleClaim>
{
    public RoleStore(ApplicationDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
    {
    }
}