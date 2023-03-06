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
    public class PaqueteConfiguration : IEntityTypeConfiguration<Paquete>
    {
        public void Configure(EntityTypeBuilder<Paquete> builder)
        {
            builder
                .HasNoKey()
                .ToTable("Paquete");

            builder.Property(e => e.Idequipo).HasColumnName("IDEquipo");
            builder.Property(e => e.Idinstalacion).HasColumnName("IDInstalacion");

            builder.HasOne(d => d.IdequipoNavigation).WithMany()
                .HasForeignKey(d => d.Idequipo)
                .HasConstraintName("FK_Paquete_Equipo");

            builder.HasOne(d => d.IdinstalacionNavigation).WithMany()
                .HasForeignKey(d => d.Idinstalacion)
                .HasConstraintName("FK_Paquete_Instalaciones");
        }
    }
}
