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
    public class MasterSystemRoleConfiguration : IEntityTypeConfiguration<MasterSystemRole>
    {
        public void Configure(EntityTypeBuilder<MasterSystemRole> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasMaxLength(450);
            builder.Property(e => e.RoleName).HasMaxLength(450);
        }
    }
}
