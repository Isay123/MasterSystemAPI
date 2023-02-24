using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Evidencia
{
    public int Id { get; set; }

    public int? Idservicios { get; set; }

    public string? Nombre { get; set; }

    public string? Img { get; set; }

    public virtual Servicio? IdserviciosNavigation { get; set; }

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
