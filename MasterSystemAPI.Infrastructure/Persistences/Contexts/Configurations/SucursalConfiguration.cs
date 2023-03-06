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
    public class SucursalConfiguration : IEntityTypeConfiguration<Sucursal>
    {
        public void Configure(EntityTypeBuilder<Sucursal> builder)
        {
            builder.HasKey(e => e.Idsucursal);

            builder.ToTable("Sucursal");

            builder.Property(e => e.Idsucursal).HasColumnName("IDSucursal");
            builder.Property(e => e.Nombre).HasMaxLength(100);

            builder.HasOne(d => d.ColoniaNavigation).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.Colonia)
                .HasConstraintName("FK_Sucursal_Colonia");

            builder.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.Municipio)
                .HasConstraintName("FK_Sucursal_Municipio");
        }
    }
}
