using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Empleado : BaseEntity
{
    public string Nombre { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public int IdCargoFk { get; set; }

    public int IdMunicipioFk { get; set; }

    public virtual Cargo IdCargoFkNavigation { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; }

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
