using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Talla : BaseEntity
{
    public string Descripcion { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual ICollection<Inventario> IdInvFks { get; set; } = new List<Inventario>();
}
