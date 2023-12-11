using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DetalleOrden : BaseEntity
{
    public int PrendaId { get; set; }

    public int CantidadProducir { get; set; }

    public int CantidadProducida { get; set; }

    public int IdOrdenFk { get; set; }

    public int IdPrendaFk { get; set; }

    public int IdColorFk { get; set; }

    public int IdEstadoFk { get; set; }

    public virtual Color IdColorFkNavigation { get; set; }

    public virtual Estado IdEstadoFkNavigation { get; set; }

    public virtual Orden IdOrdenFkNavigation { get; set; }

    public virtual Prenda IdPrendaFkNavigation { get; set; }
}
