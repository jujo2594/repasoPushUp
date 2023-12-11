using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class InsumoPrenda : BaseEntity
{
    public int IdInsumoFk { get; set; }
    public int IdPrendaFk { get; set; }
    public int Cantidad { get; set; }
    public virtual Insumo IdInsumoFkNavigation { get; set; }
    public virtual Prenda IdPrendaFkNavigation { get; set; }
}
