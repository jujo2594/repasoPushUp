using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FormaPago : BaseEntity
{
    public string Descripcion { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
