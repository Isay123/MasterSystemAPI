using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MasterSystemAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSystemAPI.Infrastructure.Persistences.Contexts.Configurations
{
    public class AtencionClienteConfiguration : IEntityTypeConfiguration<AtencionCliente>
    {
        public void Configure(EntityTypeBuilder<AtencionCliente> builder)
        {
            builder.HasKey(e => e.Idatencion);

            builder.ToTable("AtencionCliente");

            builder.Property(e => e.Idatencion).HasColumnName("IDAtencion");
            builder.Property(e => e.Idcliente).HasColumnName("IDCliente");
            builder.Property(e => e.Idservicio).HasColumnName("IDServicio");
            builder.Property(e => e.Status).HasMaxLength(100);

            builder.HasOne(d => d.IdclienteNavigation).WithMany(p => p.AtencionClientes)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_AtencionCliente_Clientes");

            builder.HasOne(d => d.IdservicioNavigation).WithMany(p => p.AtencionClientes)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_AtencionCliente_Servicios");

            builder.HasOne(d => d.UsuarioAtencionNavigation).WithMany(p => p.AtencionClientes)
                .HasForeignKey(d => d.UsuarioAtencion)
                .HasConstraintName("FK_AtencionCliente_MasterSystemUsers");
        }
    }
}
