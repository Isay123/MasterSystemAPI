using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class AtencionCliente
{
    public int Idatencion { get; set; }

    public int? Idcliente { get; set; }

    public int? Idservicio { get; set; }

    public int? UsuarioAtencion { get; set; }

    public string? Status { get; set; }

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual Servicio? IdservicioNavigation { get; set; }

    public virtual MasterSystemUser? UsuarioAtencionNavigation { get; set; }
}
