using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Servidore
{
    public int Idservidor { get; set; }

    public string? Nombre { get; set; }

    public int? Idsector { get; set; }

    public int? Idtorre { get; set; }

    public int? SegmentoIp { get; set; }

    public virtual Sectore? IdsectorNavigation { get; set; }

    public virtual Torre? IdtorreNavigation { get; set; }

    public virtual ICollection<Ip> Ips { get; } = new List<Ip>();

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
