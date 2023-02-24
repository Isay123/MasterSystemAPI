using System;
using System.Collections.Generic;

namespace MasterSystemAPI.Domain.Entities;

public partial class ServidorSegmento
{
    public int? Idservidor { get; set; }

    public int? Idsegmento { get; set; }

    public virtual IpSegmento? IdsegmentoNavigation { get; set; }

    public virtual Servidore? IdservidorNavigation { get; set; }
}
