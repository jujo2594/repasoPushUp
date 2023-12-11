using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("cliente");

            builder.HasIndex(e => e.IdCliente, "IdCliente").IsUnique();

            builder.HasIndex(e => e.IdMunicipioFk, "IdMunicipioFk");

            builder.HasIndex(e => e.IdTipoPersonaFk, "IdTipoPersonaFk");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            builder.Property(e => e.IdCliente).IsRequired();
            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombre");

            builder.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_ibfk_1");

            builder.HasOne(d => d.IdTipoPersonaFkNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdTipoPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_ibfk_2");
        }
    }
}