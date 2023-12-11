using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Prenda : BaseEntity
{
    public string Nombre { get; set; }

    public decimal ValorUnitCop { get; set; }

    public decimal ValorUnitUsd { get; set; }

    public string Codigo { get; set; }

    public int IdEstadoFk { get; set; }

    public int IdTipoProteccion { get; set; }

    public int IdGeneroFk { get; set; }

    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

    public virtual Estado IdEstadoFkNavigation { get; set; }

    public virtual Genero IdGeneroFkNavigation { get; set; }

    public virtual TipoProteccion IdTipoProteccionNavigation { get; set; }

    public virtual ICollection<InsumoPrenda> InsumoPrenda { get; set; } = new List<InsumoPrenda>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
}
