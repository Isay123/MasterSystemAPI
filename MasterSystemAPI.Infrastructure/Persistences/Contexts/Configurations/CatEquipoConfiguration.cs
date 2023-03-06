using MasterSystemAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSystemAPI.Infrastructure.Persistences.Contexts.Configurations
{
    public class CatEquipoConfiguration : IEntityTypeConfiguration<CatEquipo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CatEquipo> builder)
        {
            builder.ToTable("Cat_Equipo");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Status).HasMaxLength(100);
        }
    }
}
