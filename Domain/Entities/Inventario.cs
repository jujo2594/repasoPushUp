using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Inventario : BaseEntity
{
    public string CodInv { get; set; }

    public decimal ValorVtaCop { get; set; }

    public decimal ValorVtaUsd { get; set; }

    public int IdPrendaFk { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Prenda IdPrendaFkNavigation { get; set; }

    public virtual ICollection<Talla> IdTallaFks { get; set; } = new List<Talla>();
}
