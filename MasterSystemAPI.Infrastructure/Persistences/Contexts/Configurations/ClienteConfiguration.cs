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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.ApMaterno).HasMaxLength(100);
            builder.Property(e => e.ApPaterno).HasMaxLength(100);
            builder.Property(e => e.Direccion).HasMaxLength(250);
            builder.Property(e => e.FechaRegistro).HasColumnType("datetime");
            builder.Property(e => e.Nombre).HasMaxLength(100);
            builder.Property(e => e.Nombreempresa).HasMaxLength(2500);
            builder.Property(e => e.Telefono).HasMaxLength(50);

            builder.HasOne(d => d.ColoniaNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.Colonia)
                .HasConstraintName("FK_Clientes_Colonia");

            builder.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.Municipio)
                .HasConstraintName("FK_Clientes_Municipio");
        }
    }
}
