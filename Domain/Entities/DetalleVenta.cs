using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DetalleVenta : BaseEntity
{
    public int Cantidad { get; set; }

    public decimal ValorUnit { get; set; }

    public int IdVentaFk { get; set; }

    public int IdProductoFk { get; set; }

    public int IdTallaFk { get; set; }

    public virtual Inventario IdProductoFkNavigation { get; set; }

    public virtual Talla IdTallaFkNavigation { get; set; }

    public virtual Venta IdVentaFkNavigation { get; set; }
}
