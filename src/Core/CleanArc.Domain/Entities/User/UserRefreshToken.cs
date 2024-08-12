using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities.User;

public class UserRefreshToken:BaseEntity<Guid>
{
    public UserRefreshToken()
    {
        CreatedAt=DateTime.Now;
    }

    public long UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsValid { get; set; }
}