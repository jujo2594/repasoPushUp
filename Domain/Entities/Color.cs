using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Color : BaseEntity
{
    public string Descripcion { get; set; }

    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();
}
