using MasterSystemAPI.Infrastructure.Persistences.Contexts;
using MasterSystemAPI.Infrastructure.Persistences.Interface;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSystemAPI.Infrastructure.Persistences.Repositories
{
    public class UnitOfWork
    {
        private readonly MasterSystemContext _context;

        public IMunicipioRepository Municipio { get; private set; }

        public UnitOfWork(MasterSystemContext context)
        {
            _context = context;
            Municipio = new MunicipioRepository(_context);
        }

        public void Dispose() 
        { 
           _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public async Task SaveChangeAsync()

        { 
            await _context.SaveChangesAsync();
        }
    }
}
