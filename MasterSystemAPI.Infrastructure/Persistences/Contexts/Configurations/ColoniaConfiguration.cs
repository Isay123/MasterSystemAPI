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
    public class ColoniaConfiguration : IEntityTypeConfiguration<Colonia>
    {
        public void Configure(EntityTypeBuilder<Colonia> builder)
        {
            builder.HasKey(e => e.Idcolonia);

            builder.Property(e => e.Idcolonia).HasColumnName("IDColonia");
            builder.Property(e => e.CodigoPostal).HasMaxLength(50);
            builder.Property(e => e.Colonia).HasMaxLength(150);
        }
    }
}
