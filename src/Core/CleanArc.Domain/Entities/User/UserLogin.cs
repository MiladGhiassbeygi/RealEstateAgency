using CleanArc.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArc.Domain.Entities.User;

public class UserLogin:IdentityUserLogin<long>,IEntity
{
    public UserLogin()
    {
        LoggedOn=DateTime.Now;
    }

    public User User { get; set; }
    public DateTime LoggedOn { get; set; }
}