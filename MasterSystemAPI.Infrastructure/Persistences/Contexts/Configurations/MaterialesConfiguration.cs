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
    public class MaterialesConfiguration : IEntityTypeConfiguration<Materiales>
    {
        public void Configure(EntityTypeBuilder<Materiales> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Idservicios).HasColumnName("IDServicios");
            builder.Property(e => e.Nombre).HasMaxLength(250);

            builder.HasOne(d => d.IdserviciosNavigation).WithMany(p => p.Materiales)
                .HasForeignKey(d => d.Idservicios)
                .HasConstraintName("FK_Materiales_Servicios");
        }
    }
}
