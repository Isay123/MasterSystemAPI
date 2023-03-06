using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSystemAPI.Infrastructure.Persistences.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IMunicipioRepository Municipio { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
