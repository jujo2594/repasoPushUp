using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Cliente : BaseEntity
{
    public string Nombre { get; set; }

    public string IdCliente { get; set; }

    public DateOnly FechaRegistro { get; set; }

    public int IdTipoPersonaFk { get; set; }

    public int IdMunicipioFk { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; }

    public virtual TipoPersona IdTipoPersonaFkNavigation { get; set; }

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
