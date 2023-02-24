using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Prorroga
{
    public int Idprorroga { get; set; }

    public int? UsuarioP { get; set; }

    public int? Idservicio { get; set; }

    public int? Idcliente { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public int? CantidadMeses { get; set; }

    public string? Motivo { get; set; }

    public bool? Status { get; set; }

    public DateTime? FechaRevision { get; set; }

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
