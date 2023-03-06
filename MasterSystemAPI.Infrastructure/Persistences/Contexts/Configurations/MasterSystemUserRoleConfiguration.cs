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
    public class MasterSystemUserRoleConfiguration : IEntityTypeConfiguration<MasterSystemUserRole>
    {
        public void Configure(EntityTypeBuilder<MasterSystemUserRole> builder)
        {

            builder.HasNoKey();

            builder.HasOne(d => d.Role).WithMany()
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_MasterSystemUserRoles_MasterSystemRoles");

            builder.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_MasterSystemUserRoles_MasterSystemUsers");
        }
    }
}
