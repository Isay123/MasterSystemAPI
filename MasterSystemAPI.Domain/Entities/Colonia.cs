using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Colonia
{
    public int Idcolonia { get; set; }

    public string? Colonia { get; set; }

    public string? CodigoPostal { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Cliente> Clientes { get; } = new List<Cliente>();

    public virtual ICollection<Sectore> Sectores { get; } = new List<Sectore>();

    public virtual ICollection<Sucursal> Sucursals { get; } = new List<Sucursal>();
}
