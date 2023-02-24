using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Pago
{
    public int Idpago { get; set; }

    public int? Idservicio { get; set; }

    public int? Idcliente { get; set; }

    public int? UsuarioCobro { get; set; }

    public int? Idfactura { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? Img { get; set; }

    public bool? Status { get; set; }

    public int? Idprorroga { get; set; }

    public int? Idsucursal { get; set; }

    public virtual ICollection<Factura> Facturas { get; } = new List<Factura>();

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual Factura? IdfacturaNavigation { get; set; }

    public virtual Prorroga? IdprorrogaNavigation { get; set; }

    public virtual Servicio? IdservicioNavigation { get; set; }

    public virtual Sucursal? IdsucursalNavigation { get; set; }

    public virtual MasterSystemUser? UsuarioCobroNavigation { get; set; }
}
