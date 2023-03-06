using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Servicio
{
    public int Id { get; set; }

    public string? NumeroServicio { get; set; }

    public int? Idcliente { get; set; }

    public int? UsuarioServicio { get; set; }

    public int? Torre { get; set; }

    public int? Sector { get; set; }

    public int? Servidor { get; set; }

    public int? Ip { get; set; }

    public int? Antena { get; set; }

    public int? Router { get; set; }

    public int? Servicio1 { get; set; }

    public int? Instalacion { get; set; }

    public DateTime? FechaInicioCorte { get; set; }

    public DateTime? FechaCorte { get; set; }

    public int? Status { get; set; }

    public int? Prorroga { get; set; }

    public int? Idmateriales { get; set; }

    public int? Idevidencias { get; set; }

    public virtual ICollection<Antena> Antenas { get; } = new List<Antena>();

    public virtual ICollection<AtencionCliente> AtencionClientes { get; } = new List<AtencionCliente>();

    public virtual ICollection<Evidencia> Evidencia { get; } = new List<Evidencia>();

    public virtual ICollection<Factura> Facturas { get; } = new List<Factura>();

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual Evidencia? IdevidenciasNavigation { get; set; }

    public virtual Materiales? IdmaterialesNavigation { get; set; }

    public virtual Instalacione? InstalacionNavigation { get; set; }

    public virtual ICollection<Ip> Ips { get; } = new List<Ip>();

    public virtual ICollection<Materiales> Materiales { get; } = new List<Materiales>();

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual Prorroga? ProrrogaNavigation { get; set; }

    public virtual ICollection<Router> Routers { get; } = new List<Router>();

    public virtual Sectore? SectorNavigation { get; set; }

    public virtual Modalidad? Servicio1Navigation { get; set; }

    public virtual Servidore? ServidorNavigation { get; set; }

    public virtual CatServicio? StatusNavigation { get; set; }

    public virtual Torre? TorreNavigation { get; set; }

    public virtual MasterSystemUser? UsuarioServicioNavigation { get; set; }
}
