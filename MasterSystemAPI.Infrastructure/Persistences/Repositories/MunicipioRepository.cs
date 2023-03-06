using MasterSystemAPI.Domain.Entities;
using MasterSystemAPI.Infrastructure.Persistences.Contexts;
using MasterSystemAPI.Infrastructure.Persistences.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSystemAPI.Infrastructure.Persistences.Repositories
{
    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipioRepository
    {
        private readonly MasterSystemContext _context;

        public MunicipioRepository(MasterSystemContext context)
        {
            _context = context;
        }
    }
}
