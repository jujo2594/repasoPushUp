using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Proveedor : BaseEntity
{
    public string NitProveedor { get; set; }

    public string Nombre { get; set; }

    public int IdTipoPersona { get; set; }

    public int IdMunicipioFk { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; }

    public virtual TipoPersona IdTipoPersonaNavigation { get; set; }

    public virtual ICollection<Insumo> IdInsumoFks { get; set; } = new List<Insumo>();
}
