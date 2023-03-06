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
    public class TorreConfiguration : IEntityTypeConfiguration<Torre>
    {
        public void Configure(EntityTypeBuilder<Torre> builder)
        {
            builder.HasKey(e => e.Idtorre);

            builder.Property(e => e.Idtorre).HasColumnName("IDTorre");
            builder.Property(e => e.Nombre).HasMaxLength(100);

            builder.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Torres)
                .HasForeignKey(d => d.Municipio)
                .HasConstraintName("FK_Torres_Municipio");
        }
    }
}
