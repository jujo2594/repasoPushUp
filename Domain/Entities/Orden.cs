using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Orden : BaseEntity
{
    public DateOnly Fecha { get; set; }

    public int IdEmpleadoFk { get; set; }

    public int IdClienteFk { get; set; }

    public int IdEstadoFk { get; set; }

    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

    public virtual Cliente IdClienteFkNavigation { get; set; }

    public virtual Empleado IdEmpleadoFkNavigation { get; set; }

    public virtual Estado IdEstadoFkNavigation { get; set; }
}
