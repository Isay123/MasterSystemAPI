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
    public class CatServicioConfiguration : IEntityTypeConfiguration<CatServicio>
    {
        public void Configure(EntityTypeBuilder<CatServicio> builder)
        {

            builder.ToTable("Cat_Servicios");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Status).HasMaxLength(100);
        }
    }
}
