using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class TelefonoSucursal
{
    public int Idtelefono { get; set; }

    public int? Idsucursal { get; set; }

    public string? Tipo { get; set; }

    public string? Numero { get; set; }

    public virtual Sucursal? IdsucursalNavigation { get; set; }
}
