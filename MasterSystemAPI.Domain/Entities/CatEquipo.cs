using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class CatEquipo
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Equipo> Equipos { get; } = new List<Equipo>();
}
