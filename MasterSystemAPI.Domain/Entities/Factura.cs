using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Factura
{
    public int Idfactura { get; set; }

    public int? Idservicio { get; set; }

    public int? Idcliente { get; set; }

    public int? UsuarioCobro { get; set; }

    public int? Idpago { get; set; }

    public string? TipoPago { get; set; }

    public string? FolioPago { get; set; }

    public int? Idsucursal { get; set; }

    public decimal? Pago { get; set; }

    public decimal? Cambio { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Total { get; set; }

    public string? Empresa { get; set; }

    public string? Link { get; set; }

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual Pago? IdpagoNavigation { get; set; }

    public virtual Servicio? IdservicioNavigation { get; set; }

    public virtual Sucursal? IdsucursalNavigation { get; set; }

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual MasterSystemUser? UsuarioCobroNavigation { get; set; }
}
