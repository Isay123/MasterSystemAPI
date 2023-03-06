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
    public class PagoConfiguration : IEntityTypeConfiguration<Pago>
    {
        public void Configure(EntityTypeBuilder<Pago> builder)
        {
            builder.HasKey(e => e.Idpago);

            builder.Property(e => e.Idpago).HasColumnName("IDPago");
            builder.Property(e => e.FechaPago).HasColumnType("datetime");
            builder.Property(e => e.Idcliente).HasColumnName("IDCliente");
            builder.Property(e => e.Idfactura).HasColumnName("IDFactura");
            builder.Property(e => e.Idprorroga).HasColumnName("IDProrroga");
            builder.Property(e => e.Idservicio).HasColumnName("IDServicio");
            builder.Property(e => e.Idsucursal).HasColumnName("IDSucursal");

            builder.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Pagos_Clientes");

            builder.HasOne(d => d.IdfacturaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idfactura)
                .HasConstraintName("FK_Pagos_Factura");

            builder.HasOne(d => d.IdprorrogaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idprorroga)
                .HasConstraintName("FK_Pagos_Prorroga");

            builder.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Pagos_Servicios");

            builder.HasOne(d => d.IdsucursalNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idsucursal)
                .HasConstraintName("FK_Pagos_Sucursal");

            builder.HasOne(d => d.UsuarioCobroNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.UsuarioCobro)
                .HasConstraintName("FK_Pagos_MasterSystemUsers");
        }
    }
}
