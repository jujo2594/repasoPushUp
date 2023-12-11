using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Municipio : BaseEntity
{
    public string Nombre { get; set; }

    public int IdDepartamentoFk { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual Departamento IdDepartamentoFkNavigation { get; set; }

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
