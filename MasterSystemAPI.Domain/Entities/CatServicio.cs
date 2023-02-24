using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class CatServicio
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
