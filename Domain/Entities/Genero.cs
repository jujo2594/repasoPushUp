using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Genero : BaseEntity
{
    public string Descripcion { get; set; }

    public virtual ICollection<Prenda> Prenda { get; set; } = new List<Prenda>();
}
