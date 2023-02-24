using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Materiale
{
    public int Id { get; set; }

    public int? Idservicios { get; set; }

    public string? Nombre { get; set; }

    public bool? Status { get; set; }

    public virtual Servicio? IdserviciosNavigation { get; set; }

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
