using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Cliente
{
    public int Id { get; set; }

    public string? NumeroCliente { get; set; }

    public bool? StatusTipo { get; set; }

    public string? Nombreempresa { get; set; }

    public string? Nombre { get; set; }

    public string? ApPaterno { get; set; }

    public string? ApMaterno { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public int? Municipio { get; set; }

    public int? Colonia { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Antena> Antenas { get; } = new List<Antena>();

    public virtual ICollection<AtencionCliente> AtencionClientes { get; } = new List<AtencionCliente>();

    public virtual Colonium? ColoniaNavigation { get; set; }

    public virtual ICollection<Factura> Facturas { get; } = new List<Factura>();

    public virtual ICollection<Ip> Ips { get; } = new List<Ip>();

    public virtual Municipio? MunicipioNavigation { get; set; }

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual ICollection<Router> Routers { get; } = new List<Router>();

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
