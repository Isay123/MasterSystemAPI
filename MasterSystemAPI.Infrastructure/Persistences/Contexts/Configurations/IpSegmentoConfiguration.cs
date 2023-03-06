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
    public class IpSegmentoConfiguration : IEntityTypeConfiguration<IpSegmento>
    {
        public void Configure(EntityTypeBuilder<IpSegmento> builder)
        {
            builder.HasKey(e => e.Idsegmento);

            builder.Property(e => e.Idsegmento).HasColumnName("IDSegmento");
        }
    }
}
