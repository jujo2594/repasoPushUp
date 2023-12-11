using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipoEstado : BaseEntity
{
    public string Descripcion { get; set; }

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();
}
