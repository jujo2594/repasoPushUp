using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Estado : BaseEntity
{
    public string Descripcion { get; set; }

    public int IdTipoEstadoFk { get; set; }

    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

    public virtual TipoEstado IdTipoEstadoFkNavigation { get; set; }

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();

    public virtual ICollection<Prenda> Prenda { get; set; } = new List<Prenda>();
}
