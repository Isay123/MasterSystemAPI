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
    public class InstalacioneConfiguration : IEntityTypeConfiguration<Instalacione>
    {
        public void Configure(EntityTypeBuilder<Instalacione> builder)
        {
            builder.HasKey(e => e.Idinstalacion);

            builder.Property(e => e.Idinstalacion).HasColumnName("IDInstalacion");
            builder.Property(e => e.Costo).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.Equipo).HasMaxLength(100);
            builder.Property(e => e.Tipo).HasMaxLength(100);
        }
    }
}
