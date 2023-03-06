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
    public class ZonaConfiguration : IEntityTypeConfiguration<Zona>
    {
        public void Configure(EntityTypeBuilder<Zona> builder)
        {

            builder
                .HasNoKey()
                .ToTable("Zona");

            builder.Property(e => e.Idcolonia).HasColumnName("IDColonia");
            builder.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

            builder.HasOne(d => d.IdcoloniaNavigation).WithMany()
                .HasForeignKey(d => d.Idcolonia)
                .HasConstraintName("FK_Zona_Colonia");

            builder.HasOne(d => d.IdmunicipioNavigation).WithMany()
                .HasForeignKey(d => d.Idmunicipio)
                .HasConstraintName("FK_Zona_Municipio");
        }
    }
}
