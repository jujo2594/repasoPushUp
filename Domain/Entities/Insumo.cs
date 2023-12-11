using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Insumo : BaseEntity
{
    public string Nombre { get; set; }

    public decimal ValorUnit { get; set; }

    public decimal StockMin { get; set; }

    public decimal StockMax { get; set; }

    public virtual ICollection<InsumoPrenda> InsumoPrenda { get; set; } = new List<InsumoPrenda>();

    public virtual ICollection<Proveedor> IdProveedorFks { get; set; } = new List<Proveedor>();
}
