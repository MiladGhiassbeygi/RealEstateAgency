﻿using CleanArc.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArc.Domain.Entities.User;

public class UserToken:IdentityUserToken<long>,IEntity
{
    public UserToken()
    {
        GeneratedTime=DateTime.Now;
    }

    public User User { get; set; }
    public DateTime GeneratedTime { get; set; }

}