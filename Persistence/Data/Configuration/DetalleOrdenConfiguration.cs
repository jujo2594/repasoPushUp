using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("detalle_orden");

            builder.HasIndex(e => e.IdColorFk, "IdColorFk");

            builder.HasIndex(e => e.IdEstadoFk, "IdEstadoFk");

            builder.HasIndex(e => e.IdOrdenFk, "IdOrdenFk");

            builder.HasIndex(e => e.IdPrendaFk, "IdPrendaFk");

            builder.HasIndex(e => e.PrendaId, "PrendaId").IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.CantidadProducida).HasColumnName("cantidad_producida");
            builder.Property(e => e.CantidadProducir).HasColumnName("cantidad_producir");

            builder.HasOne(d => d.IdColorFkNavigation).WithMany(p => p.DetalleOrdens)
                .HasForeignKey(d => d.IdColorFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_orden_ibfk_3");

            builder.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.DetalleOrdens)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_orden_ibfk_4");

            builder.HasOne(d => d.IdOrdenFkNavigation).WithMany(p => p.DetalleOrdens)
                .HasForeignKey(d => d.IdOrdenFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_orden_ibfk_1");

            builder.HasOne(d => d.IdPrendaFkNavigation).WithMany(p => p.DetalleOrdens)
                .HasForeignKey(d => d.IdPrendaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_orden_ibfk_2");
        }
    }
}