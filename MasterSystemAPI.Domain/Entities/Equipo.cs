using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Equipo
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public decimal? Costo { get; set; }

    public int? Status { get; set; }

    public virtual CatEquipo? StatusNavigation { get; set; }
}
