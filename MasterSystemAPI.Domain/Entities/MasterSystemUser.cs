using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class MasterSystemUser
{
    public int Id { get; set; }

    public string? NumUsuario { get; set; }

    public string? UserName { get; set; }

    public string? Nombre { get; set; }

    public string? ApPaterno { get; set; }

    public string? ApMaterno { get; set; }

    public string? Correo { get; set; }

    public string? PasswordHash { get; set; }

    public string? Telefono { get; set; }

    public int? Sucursal { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Antena> Antenas { get; } = new List<Antena>();

    public virtual ICollection<AtencionCliente> AtencionClientes { get; } = new List<AtencionCliente>();

    public virtual ICollection<Factura> Facturas { get; } = new List<Factura>();

    public virtual ICollection<Ip> Ips { get; } = new List<Ip>();

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual ICollection<Router> Routers { get; } = new List<Router>();

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();

    public virtual Sucursal? SucursalNavigation { get; set; }
}
