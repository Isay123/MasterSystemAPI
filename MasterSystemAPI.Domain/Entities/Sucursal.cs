using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Sucursal
{
    public int Idsucursal { get; set; }

    public string? NumSucursal { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public int? Municipio { get; set; }

    public int? Colonia { get; set; }

    public int? Telefono { get; set; }

    public virtual Colonia? ColoniaNavigation { get; set; }

    public virtual ICollection<Factura> Facturas { get; } = new List<Factura>();

    public virtual ICollection<MasterSystemUser> MasterSystemUsers { get; } = new List<MasterSystemUser>();

    public virtual Municipio? MunicipioNavigation { get; set; }

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual ICollection<TelefonoSucursal> TelefonoSucursals { get; } = new List<TelefonoSucursal>();
}
