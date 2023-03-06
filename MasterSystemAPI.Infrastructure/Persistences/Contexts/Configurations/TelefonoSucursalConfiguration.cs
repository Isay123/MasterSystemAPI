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
    public class TelefonoSucursalConfiguration : IEntityTypeConfiguration<TelefonoSucursal>
    {
        public void Configure(EntityTypeBuilder<TelefonoSucursal> builder)
        {
            builder.HasKey(e => e.Idtelefono);

            builder.ToTable("TelefonoSucursal");

            builder.Property(e => e.Idtelefono).HasColumnName("IDTelefono");
            builder.Property(e => e.Idsucursal).HasColumnName("IDSucursal");
            builder.Property(e => e.Numero).HasMaxLength(150);
            builder.Property(e => e.Tipo).HasMaxLength(100);

            builder.HasOne(d => d.IdsucursalNavigation).WithMany(p => p.TelefonoSucursals)
                .HasForeignKey(d => d.Idsucursal)
                .HasConstraintName("FK_TelefonoSucursal_Sucursal");
        }
    }
}
