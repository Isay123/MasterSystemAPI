using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Modalidad
{
    public int Idmodalidad { get; set; }

    public string? Nombre { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Costo { get; set; }

    public string? Upload { get; set; }

    public string? Download { get; set; }

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
