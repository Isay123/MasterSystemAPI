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
    public class MasterSystemUserConfiguration : IEntityTypeConfiguration<MasterSystemUser>
    {
        public void Configure(EntityTypeBuilder<MasterSystemUser> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.ApMaterno).HasMaxLength(100);
            builder.Property(e => e.ApPaterno).HasMaxLength(100);
            builder.Property(e => e.Correo).HasMaxLength(250);
            builder.Property(e => e.Nombre).HasMaxLength(100);
            builder.Property(e => e.Telefono).HasMaxLength(50);
            builder.Property(e => e.UserName).HasMaxLength(250);

            builder.HasOne(d => d.SucursalNavigation).WithMany(p => p.MasterSystemUsers)
                .HasForeignKey(d => d.Sucursal)
                .HasConstraintName("FK_MasterSystemUsers_Sucursal");
        }
    }
}
