using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class MasterSystemUserRole
{
    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public virtual MasterSystemRole? Role { get; set; }

    public virtual MasterSystemUser? User { get; set; }
}
