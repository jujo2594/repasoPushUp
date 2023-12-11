using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Venta : BaseEntity
{
    public DateOnly Fecha { get; set; }

    public int IdEmpleadoFk { get; set; }

    public int IdClienteFk { get; set; }

    public int IdFormaPagoFk { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Cliente IdClienteFkNavigation { get; set; }

    public virtual Empleado IdEmpleadoFkNavigation { get; set; }

    public virtual FormaPago IdFormaPagoFkNavigation { get; set; }
}
