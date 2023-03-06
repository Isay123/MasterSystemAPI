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
    public class RouterConfiguration : IEntityTypeConfiguration<Router>
    {
        public void Configure(EntityTypeBuilder<Router> builder)
        {
            builder.HasKey(e => e.Idrouter);

            builder.Property(e => e.Idrouter).HasColumnName("IDRouter");
            builder.Property(e => e.Equipo).HasMaxLength(100);
            builder.Property(e => e.Idcliente).HasColumnName("IDCliente");
            builder.Property(e => e.Idservicio).HasColumnName("IDServicio");
            builder.Property(e => e.Marca).HasMaxLength(250);
            builder.Property(e => e.Nombre).HasMaxLength(100);

            builder.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Routers)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Routers_Clientes");

            builder.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Routers)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Routers_Servicios");

            builder.HasOne(d => d.UsuarioInstaladorNavigation).WithMany(p => p.Routers)
                .HasForeignKey(d => d.UsuarioInstalador)
                .HasConstraintName("FK_Routers_MasterSystemUsers");
        }
    }
}
