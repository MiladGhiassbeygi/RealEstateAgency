﻿using CleanArc.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArc.Domain.Entities.User;

public class RoleClaim:IdentityRoleClaim<long>,IEntity
{
    public RoleClaim()
    {
        CreatedClaim=DateTime.Now;
    }

    public DateTime CreatedClaim { get; set; }
    public Role Role { get; set; }

}