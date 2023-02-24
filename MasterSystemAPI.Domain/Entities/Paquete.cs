using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Paquete
{
    public int? Idinstalacion { get; set; }

    public int? Idequipo { get; set; }

    public virtual Equipo? IdequipoNavigation { get; set; }

    public virtual Instalacione? IdinstalacionNavigation { get; set; }
}
