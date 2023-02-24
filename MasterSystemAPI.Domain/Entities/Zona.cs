using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class Zona
{
    public int? Idcolonia { get; set; }

    public int? Idmunicipio { get; set; }

    public virtual Colonium? IdcoloniaNavigation { get; set; }

    public virtual Municipio? IdmunicipioNavigation { get; set; }
}
