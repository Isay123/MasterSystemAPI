using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Router
{
    public int Idrouter { get; set; }

    public int? Idservicio { get; set; }

    public int? Idcliente { get; set; }

    public int? UsuarioInstalador { get; set; }

    public string? Nombre { get; set; }

    public string? Marca { get; set; }

    public string? NumeroSerie { get; set; }

    public int? Status { get; set; }

    public string? Equipo { get; set; }

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual Servicio? IdservicioNavigation { get; set; }

    public virtual MasterSystemUser? UsuarioInstaladorNavigation { get; set; }
}
