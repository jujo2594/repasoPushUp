using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Empresa : BaseEntity
{
    public string Nit { get; set; }

    public string RazonSocial { get; set; }

    public string RepresentanteLegal { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public int IdMunicipioFk { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; }
}
