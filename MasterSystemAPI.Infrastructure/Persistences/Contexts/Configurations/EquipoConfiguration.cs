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
    public class EquipoConfiguration : IEntityTypeConfiguration<Equipo>
    {
        public void Configure(EntityTypeBuilder<Equipo> builder)
        {
            builder.ToTable("Equipo");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Costo).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.Nombre).HasMaxLength(250);

            builder.HasOne(d => d.StatusNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_Equipo_Cat_Equipo");
        }
    }
}
