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
    public class ProrrogaConfiguration : IEntityTypeConfiguration<Prorroga>
    {
        public void Configure(EntityTypeBuilder<Prorroga> builder)
        {
            builder.HasKey(e => e.Idprorroga);

            builder.ToTable("Prorroga");

            builder.Property(e => e.Idprorroga).HasColumnName("IDProrroga");
            builder.Property(e => e.FechaRevision).HasColumnType("datetime");
            builder.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            builder.Property(e => e.Idcliente).HasColumnName("IDCliente");
            builder.Property(e => e.Idservicio).HasColumnName("IDServicio");
        }
    }
}
