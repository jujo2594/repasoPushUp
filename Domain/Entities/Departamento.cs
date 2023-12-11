using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Departamento : BaseEntity
{
    public string Nombre { get; set; }

    public int IdPaisFk { get; set; }

    public virtual Pais IdPaisFkNavigation { get; set; }

    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();
}
