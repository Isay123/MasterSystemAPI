using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MasterSystemAPI.Domain.Entities;

namespace MasterSystemAPI.Infrastructure.Persistences.Contexts.Configurations
{
    public class AntenaConguration : IEntityTypeConfiguration<Antena>
    {
        public void Configure(EntityTypeBuilder<Antena> builder)
        {
            builder.HasKey(e => e.Idantena);

            builder.Property(e => e.Idantena).HasColumnName("IDAntena");
            builder.Property(e => e.Equipo).HasMaxLength(100);
            builder.Property(e => e.Idcliente).HasColumnName("IDCliente");
            builder.Property(e => e.Idservicio).HasColumnName("IDServicio");
            builder.Property(e => e.Marca).HasMaxLength(250);
            builder.Property(e => e.Nombre).HasMaxLength(100);

            builder.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Antenas)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Antenas_Clientes");

            builder.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Antenas)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Antenas_Servicios");

            builder.HasOne(d => d.UsuarioInstaladorNavigation).WithMany(p => p.Antenas)
                .HasForeignKey(d => d.UsuarioInstalador)
                .HasConstraintName("FK_Antenas_MasterSystemUsers");
        }
    }
}
