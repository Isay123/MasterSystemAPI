using MasterSystemAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSystemAPI.Infrastructure.Persistences.Contexts.Configurations
{
    public class ModalidadConfiguration : IEntityTypeConfiguration<Modalidad>
    {
        public void Configure(EntityTypeBuilder<Modalidad> builder)
        {
            builder.HasKey(e => e.Idmodalidad);

            builder.ToTable("Modalidad");

            builder.Property(e => e.Idmodalidad).HasColumnName("IDModalidad");
            builder.Property(e => e.Costo).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.Nombre).HasMaxLength(250);
        }
    }
}
