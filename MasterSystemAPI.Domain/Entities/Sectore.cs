using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Sectore
{
    public int Idsector { get; set; }

    public string? Nombre { get; set; }

    public string? Frecuencia { get; set; }

    public string? Usuario { get; set; }

    public string? Contraseña { get; set; }

    public string? Cmh3 { get; set; }

    public string? Ssid { get; set; }

    public string? Red { get; set; }

    public int? Idtorre { get; set; }

    public string? IpInicio { get; set; }

    public string? IpFinal { get; set; }

    public int? Colonia { get; set; }

    public int? Municipio { get; set; }

    public virtual Colonium? ColoniaNavigation { get; set; }

    public virtual Municipio? MunicipioNavigation { get; set; }

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();

    public virtual ICollection<Servidore> Servidores { get; } = new List<Servidore>();
}
