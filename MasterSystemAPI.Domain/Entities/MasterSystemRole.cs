using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class MasterSystemRole
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? RoleName { get; set; }
}
