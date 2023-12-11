using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("cargos");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("descripcion");
            builder.Property(e => e.SueldoBase)
                .HasPrecision(10)
                .HasColumnName("sueldo_base");
        }
    }
}