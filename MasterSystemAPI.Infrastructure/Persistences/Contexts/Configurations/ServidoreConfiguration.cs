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
    public class ServidoreConfiguration : IEntityTypeConfiguration<Servidore>
    {
        public void Configure(EntityTypeBuilder<Servidore> builder)
        {
            builder.HasKey(e => e.Idservidor);

            builder.Property(e => e.Idservidor).HasColumnName("IDServidor");
            builder.Property(e => e.Idsector).HasColumnName("IDSector");
            builder.Property(e => e.Idtorre).HasColumnName("IDTorre");
            builder.Property(e => e.Nombre).HasMaxLength(100);

            builder.HasOne(d => d.IdsectorNavigation).WithMany(p => p.Servidores)
                .HasForeignKey(d => d.Idsector)
                .HasConstraintName("FK_Servidores_Sectores");

            builder.HasOne(d => d.IdtorreNavigation).WithMany(p => p.Servidores)
                .HasForeignKey(d => d.Idtorre)
                .HasConstraintName("FK_Servidores_Torres");
        }
    }
}
