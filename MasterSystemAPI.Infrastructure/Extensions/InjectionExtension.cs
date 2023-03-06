using MasterSystemAPI.Infrastructure.Persistences.Contexts;
using MasterSystemAPI.Infrastructure.Persistences.Interface;
using MasterSystemAPI.Infrastructure.Persistences.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSystemAPI.Infrastructure.Extensions
{
    public static class InjectionExtension
    {
        public static IServiceCollection AddInjectionInterfaceestructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(MasterSystemContext).Assembly.FullName;

            services.AddDbContext<MasterSystemContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("MasterSystemConnection"), b => b.MigrationsAssembly(assembly)),ServiceLifetime.Transient);

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
