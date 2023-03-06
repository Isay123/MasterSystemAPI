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
    public class IpConfiguration : IEntityTypeConfiguration<Ip>
    {
        public void Configure(EntityTypeBuilder<Ip> builder)
        {
            builder.HasKey(e => e.Idip);

            builder.ToTable("Ip");

            builder.Property(e => e.Idip).HasColumnName("IDIp");
            builder.Property(e => e.Idcliente).HasColumnName("IDCliente");
            builder.Property(e => e.Idsegmento).HasColumnName("IDSegmento");
            builder.Property(e => e.Idservicio).HasColumnName("IDServicio");
            builder.Property(e => e.Idservidor).HasColumnName("IDServidor");
            builder.Property(e => e.Target).HasMaxLength(250);

            builder.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Ips)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Ip_Clientes");

            builder.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Ips)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Ip_Servicios");

            builder.HasOne(d => d.IdservidorNavigation).WithMany(p => p.Ips)
                .HasForeignKey(d => d.Idservidor)
                .HasConstraintName("FK_Ip_Servidores");

            builder.HasOne(d => d.UsuarioInfraNavigation).WithMany(p => p.Ips)
                .HasForeignKey(d => d.UsuarioInfra)
                .HasConstraintName("FK_Ip_MasterSystemUsers");
        }
    }
}
