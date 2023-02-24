using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Ip
{
    public int Idip { get; set; }

    public int? Idcliente { get; set; }

    public int? Idservicio { get; set; }

    public int? Idservidor { get; set; }

    public int? UsuarioInfra { get; set; }

    public string? Target { get; set; }

    public string? Upload { get; set; }

    public string? Download { get; set; }

    public bool? Status { get; set; }

    public int? Idsegmento { get; set; }

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual Servicio? IdservicioNavigation { get; set; }

    public virtual Servidore? IdservidorNavigation { get; set; }

    public virtual MasterSystemUser? UsuarioInfraNavigation { get; set; }
}
