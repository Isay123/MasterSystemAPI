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
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.HasKey(e => e.Idfactura);

            builder.ToTable("Factura");

            builder.Property(e => e.Idfactura).HasColumnName("IDFactura");
            builder.Property(e => e.Cambio).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.FolioPago).HasMaxLength(250);
            builder.Property(e => e.Idcliente).HasColumnName("IDCliente");
            builder.Property(e => e.Idpago).HasColumnName("IDPago");
            builder.Property(e => e.Idservicio).HasColumnName("IDServicio");
            builder.Property(e => e.Idsucursal).HasColumnName("IDSucursal");
            builder.Property(e => e.Iva).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.Link).HasMaxLength(150);
            builder.Property(e => e.Pago).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.Subtotal).HasColumnType("decimal(18, 0)");
            builder.Property(e => e.TipoPago).HasMaxLength(150);
            builder.Property(e => e.Total).HasColumnType("decimal(18, 0)");

            builder.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Factura_Clientes");

            builder.HasOne(d => d.IdpagoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idpago)
                .HasConstraintName("FK_Factura_Pagos");

            builder.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Factura_Servicios");

            builder.HasOne(d => d.IdsucursalNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idsucursal)
                .HasConstraintName("FK_Factura_Sucursal");

            builder.HasOne(d => d.UsuarioCobroNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.UsuarioCobro)
                .HasConstraintName("FK_Factura_MasterSystemUsers");
        }
    }
}
