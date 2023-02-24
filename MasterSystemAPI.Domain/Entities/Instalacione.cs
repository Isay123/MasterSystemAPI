using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Instalacione
{
    public int Idinstalacion { get; set; }

    public string? Tipo { get; set; }

    public decimal? Costo { get; set; }

    public int? Zona { get; set; }

    public string? Equipo { get; set; }

    public int? Incluye { get; set; }

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
