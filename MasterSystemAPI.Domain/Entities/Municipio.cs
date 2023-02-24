using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Municipio
{
    public int Idmunicipio { get; set; }

    public string? Municipio1 { get; set; }

    public string? Estado { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Cliente> Clientes { get; } = new List<Cliente>();

    public virtual ICollection<Sectore> Sectores { get; } = new List<Sectore>();

    public virtual ICollection<Sucursal> Sucursals { get; } = new List<Sucursal>();

    public virtual ICollection<Torre> Torres { get; } = new List<Torre>();
}
