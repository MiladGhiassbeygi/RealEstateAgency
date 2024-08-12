using CleanArc.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArc.Domain.Entities.User;

public class UserClaim:IdentityUserClaim<long>,IEntity
{
    public User User { get; set; }
}