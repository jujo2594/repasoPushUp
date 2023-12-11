using System;
using System.Collections.Generic;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Persistence.Data;

public partial class contextPushUp : DbContext
{
    public contextPushUp()
    {
    }

    public contextPushUp(DbContextOptions<contextPushUp> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DetalleOrden> DetalleOrdens { get; set; }

    public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Insumo> Insumos { get; set; }

    public virtual DbSet<InsumoPrenda> InsumoPrendas { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Orden> Ordens { get; set; }

    public virtual DbSet<Pais> Pais { get; set; }

    public virtual DbSet<Prenda> Prenda { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Talla> Tallas { get; set; }

    public virtual DbSet<TipoEstado> TipoEstados { get; set; }

    public virtual DbSet<TipoPersona> TipoPersonas { get; set; }

    public virtual DbSet<TipoProteccion> TipoProteccions { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cargo>(entity =>
        {

        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            
        });

        modelBuilder.Entity<Color>(entity =>
        {

        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            
        });

        modelBuilder.Entity<DetalleOrden>(entity =>
        {
            
        });

        modelBuilder.Entity<DetalleVenta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("detalle_venta");

            entity.HasIndex(e => e.IdProductoFk, "IdProductoFk");

            entity.HasIndex(e => e.IdTallaFk, "IdTallaFk");

            entity.HasIndex(e => e.IdVentaFk, "IdVentaFk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.ValorUnit)
                .HasPrecision(10)
                .HasColumnName("valor_unit");

            entity.HasOne(d => d.IdProductoFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProductoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_venta_ibfk_2");

            entity.HasOne(d => d.IdTallaFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdTallaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_venta_ibfk_3");

            entity.HasOne(d => d.IdVentaFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVentaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_venta_ibfk_1");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("empleado");

            entity.HasIndex(e => e.IdCargoFk, "IdCargoFk");

            entity.HasIndex(e => e.IdMunicipioFk, "IdMunicipioFk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdCargoFkNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdCargoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleado_ibfk_1");

            entity.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleado_ibfk_2");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("empresa");

            entity.HasIndex(e => e.IdMunicipioFk, "IdMunicipioFk");

            entity.HasIndex(e => e.Nit, "nit").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nit)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nit");
            entity.Property(e => e.RazonSocial)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("razon_social");
            entity.Property(e => e.RepresentanteLegal)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("representante_legal");

            entity.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empresa_ibfk_1");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("estado");

            entity.HasIndex(e => e.IdTipoEstadoFk, "IdTipoEstadoFk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.IdTipoEstadoFkNavigation).WithMany(p => p.Estados)
                .HasForeignKey(d => d.IdTipoEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("estado_ibfk_1");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("forma_pago");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("genero");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Insumo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("insumo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.StockMax)
                .HasPrecision(10)
                .HasColumnName("stock_max");
            entity.Property(e => e.StockMin)
                .HasPrecision(10)
                .HasColumnName("stock_min");
            entity.Property(e => e.ValorUnit)
                .HasPrecision(10)
                .HasColumnName("valor_unit");

            entity.HasMany(d => d.IdProveedorFks).WithMany(p => p.IdInsumoFks)
                .UsingEntity<Dictionary<string, object>>(
                    "InsumoProveedor",
                    r => r.HasOne<Proveedor>().WithMany()
                        .HasForeignKey("IdProveedorFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("insumo_proveedor_ibfk_2"),
                    l => l.HasOne<Insumo>().WithMany()
                        .HasForeignKey("IdInsumoFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("insumo_proveedor_ibfk_1"),
                    j =>
                    {
                        j.HasKey("IdInsumoFk", "IdProveedorFk")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("insumo_proveedor");
                        j.HasIndex(new[] { "IdProveedorFk" }, "IdProveedorFk");
                    });
        });

        modelBuilder.Entity<InsumoPrenda>(entity =>
        {
            entity.HasKey(e => new { e.IdInsumoFk, e.IdPrendaFk })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("insumo_prendas");

            entity.HasIndex(e => e.IdPrendaFk, "IdPrendaFk");

            entity.HasOne(d => d.IdInsumoFkNavigation).WithMany(p => p.InsumoPrenda)
                .HasForeignKey(d => d.IdInsumoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("insumo_prendas_ibfk_1");

            entity.HasOne(d => d.IdPrendaFkNavigation).WithMany(p => p.InsumoPrenda)
                .HasForeignKey(d => d.IdPrendaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("insumo_prendas_ibfk_2");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("inventario");

            entity.HasIndex(e => e.CodInv, "CodInv").IsUnique();

            entity.HasIndex(e => e.IdPrendaFk, "IdPrendaFk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodInv).IsRequired();
            entity.Property(e => e.ValorVtaCop).HasPrecision(10);
            entity.Property(e => e.ValorVtaUsd).HasPrecision(10);

            entity.HasOne(d => d.IdPrendaFkNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.IdPrendaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("inventario_ibfk_1");

            entity.HasMany(d => d.IdTallaFks).WithMany(p => p.IdInvFks)
                .UsingEntity<Dictionary<string, object>>(
                    "InventarioTalla",
                    r => r.HasOne<Talla>().WithMany()
                        .HasForeignKey("IdTallaFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("inventario_talla_ibfk_2"),
                    l => l.HasOne<Inventario>().WithMany()
                        .HasForeignKey("IdInvFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("inventario_talla_ibfk_1"),
                    j =>
                    {
                        j.HasKey("IdInvFk", "IdTallaFk")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("inventario_talla");
                        j.HasIndex(new[] { "IdTallaFk" }, "IdTallaFk");
                    });
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("municipio");

            entity.HasIndex(e => e.IdDepartamentoFk, "IdDepartamentoFk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDepartamentoFkNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.IdDepartamentoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("municipio_ibfk_1");
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("orden");

            entity.HasIndex(e => e.IdClienteFk, "IdClienteFk");

            entity.HasIndex(e => e.IdEmpleadoFk, "IdEmpleadoFk");

            entity.HasIndex(e => e.IdEstadoFk, "IdEstadoFk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha).HasColumnName("fecha");

            entity.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("orden_ibfk_2");

            entity.HasOne(d => d.IdEmpleadoFkNavigation).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.IdEmpleadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("orden_ibfk_1");

            entity.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("orden_ibfk_3");
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pais");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Prenda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prenda");

            entity.HasIndex(e => e.Codigo, "Codigo").IsUnique();

            entity.HasIndex(e => e.IdEstadoFk, "IdEstadoFk");

            entity.HasIndex(e => e.IdGeneroFk, "IdGeneroFk");

            entity.HasIndex(e => e.IdTipoProteccion, "IdTipoProteccion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ValorUnitCop).HasPrecision(10);
            entity.Property(e => e.ValorUnitUsd).HasPrecision(10);

            entity.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.Prenda)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prenda_ibfk_1");

            entity.HasOne(d => d.IdGeneroFkNavigation).WithMany(p => p.Prenda)
                .HasForeignKey(d => d.IdGeneroFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prenda_ibfk_3");

            entity.HasOne(d => d.IdTipoProteccionNavigation).WithMany(p => p.Prenda)
                .HasForeignKey(d => d.IdTipoProteccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prenda_ibfk_2");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("proveedor");

            entity.HasIndex(e => e.IdMunicipioFk, "IdMunicipioFk");

            entity.HasIndex(e => e.IdTipoPersona, "IdTipoPersona");

            entity.HasIndex(e => e.NitProveedor, "NitProveedor").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NitProveedor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedor_ibfk_1");

            entity.HasOne(d => d.IdTipoPersonaNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdTipoPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedor_ibfk_2");
        });

        modelBuilder.Entity<Talla>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("talla");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<TipoEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipo_estado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<TipoPersona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipo_persona");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<TipoProteccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipo_proteccion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("venta");

            entity.HasIndex(e => e.IdClienteFk, "IdClienteFk");

            entity.HasIndex(e => e.IdEmpleadoFk, "IdEmpleadoFk");

            entity.HasIndex(e => e.IdFormaPagoFk, "IdFormaPagoFk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha).HasColumnName("fecha");

            entity.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("venta_ibfk_2");

            entity.HasOne(d => d.IdEmpleadoFkNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdEmpleadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("venta_ibfk_1");

            entity.HasOne(d => d.IdFormaPagoFkNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdFormaPagoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("venta_ibfk_3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
