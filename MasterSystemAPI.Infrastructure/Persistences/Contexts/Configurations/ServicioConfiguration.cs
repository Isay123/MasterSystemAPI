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
    public class ServicioConfiguration : IEntityTypeConfiguration<Servicio>
    {
        public void Configure(EntityTypeBuilder<Servicio> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.FechaCorte).HasColumnType("datetime");
            builder.Property(e => e.FechaInicioCorte).HasColumnType("datetime");
            builder.Property(e => e.Idcliente).HasColumnName("IDCliente");
            builder.Property(e => e.Idevidencias).HasColumnName("IDEvidencias");
            builder.Property(e => e.Idmateriales).HasColumnName("IDMateriales");
            builder.Property(e => e.Servicio1).HasColumnName("Servicio");

            builder.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Servicios_Clientes");

            builder.HasOne(d => d.IdevidenciasNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Idevidencias)
                .HasConstraintName("FK_Servicios_Evidencias");

            builder.HasOne(d => d.IdmaterialesNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Idmateriales)
                .HasConstraintName("FK_Servicios_Materiales");

            builder.HasOne(d => d.InstalacionNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Instalacion)
                .HasConstraintName("FK_Servicios_Instalaciones");

            builder.HasOne(d => d.ProrrogaNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Prorroga)
                .HasConstraintName("FK_Servicios_Prorroga");

            builder.HasOne(d => d.SectorNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Sector)
                .HasConstraintName("FK_Servicios_Sectores");

            builder.HasOne(d => d.Servicio1Navigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Servicio1)
                .HasConstraintName("FK_Servicios_Modalidad");

            builder.HasOne(d => d.ServidorNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Servidor)
                .HasConstraintName("FK_Servicios_Servidores");

            builder.HasOne(d => d.StatusNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_Servicios_Cat_Servicios");

            builder.HasOne(d => d.TorreNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Torre)
                .HasConstraintName("FK_Servicios_Torres");

            builder.HasOne(d => d.UsuarioServicioNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.UsuarioServicio)
                .HasConstraintName("FK_Servicios_MasterSystemUsers");
        }
    }
}
