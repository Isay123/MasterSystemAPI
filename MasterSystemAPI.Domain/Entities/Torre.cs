using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Torre
{
    public int Idtorre { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public int? Municipio { get; set; }

    public string? Coordenadas { get; set; }

    public string? Descripcion { get; set; }

    public virtual Municipio? MunicipioNavigation { get; set; }

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();

    public virtual ICollection<Servidore> Servidores { get; } = new List<Servidore>();
}
