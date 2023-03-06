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
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.HasKey(e => e.Idmunicipio);

            builder.ToTable("Municipio");

            builder.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");
            builder.Property(e => e.Estado).HasMaxLength(150);
            builder.Property(e => e.Municipio1)
                .HasMaxLength(150)
                .HasColumnName("Municipio");
        }
    }
}
