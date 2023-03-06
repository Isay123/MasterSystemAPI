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
    public class ServidorSegmentoConfiguration : IEntityTypeConfiguration<ServidorSegmento>
    {
        public void Configure(EntityTypeBuilder<ServidorSegmento> builder)
        {
            builder
              .HasNoKey()
              .ToTable("Servidor_Segmento");

            builder.Property(e => e.Idsegmento).HasColumnName("IDSegmento");
            builder.Property(e => e.Idservidor).HasColumnName("IDServidor");

            builder.HasOne(d => d.IdsegmentoNavigation).WithMany()
                .HasForeignKey(d => d.Idsegmento)
                .HasConstraintName("FK_Servidor_Segmento_IpSegmentos");

            builder.HasOne(d => d.IdservidorNavigation).WithMany()
                .HasForeignKey(d => d.Idservidor)
                .HasConstraintName("FK_Servidor_Segmento_Servidores");
        }
    }
}
