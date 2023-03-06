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
    public class SectoreConfiguration : IEntityTypeConfiguration<Sectore>
    {
        public void Configure(EntityTypeBuilder<Sectore> builder)
        {

            builder.HasKey(e => e.Idsector);

            builder.Property(e => e.Idsector).HasColumnName("IDSector");
            builder.Property(e => e.Cmh3)
                .HasMaxLength(100)
                .HasColumnName("CMH3");
            builder.Property(e => e.Contraseña).HasMaxLength(100);
            builder.Property(e => e.Frecuencia).HasMaxLength(100);
            builder.Property(e => e.Idtorre).HasColumnName("IDTorre");
            builder.Property(e => e.IpFinal).HasMaxLength(100);
            builder.Property(e => e.IpInicio).HasMaxLength(100);
            builder.Property(e => e.Nombre).HasMaxLength(100);
            builder.Property(e => e.Red).HasMaxLength(100);
            builder.Property(e => e.Ssid)
                .HasMaxLength(100)
                .HasColumnName("SSID");
            builder.Property(e => e.Usuario).HasMaxLength(100);

            builder.HasOne(d => d.ColoniaNavigation).WithMany(p => p.Sectores)
                .HasForeignKey(d => d.Colonia)
                .HasConstraintName("FK_Sectores_Colonia");

            builder.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Sectores)
                .HasForeignKey(d => d.Municipio)
                .HasConstraintName("FK_Sectores_Municipio");
        }
    }
}
