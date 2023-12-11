using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipoPersona : BaseEntity
{
    public string Nombre { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
