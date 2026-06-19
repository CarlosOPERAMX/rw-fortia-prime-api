using rw_fortia_prime_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace rw_fortia_prime_api.Services
{
    public class CatalogosService
    {
        private readonly FortiaDbContext _context;

        public CatalogosService(FortiaDbContext context)
        {
            _context = context;
        }

        public async Task<List<RhPuesto>> ConsultarPuestos()
        {
            var data = await _context.RhPuestos
                .ToListAsync();

            return data;
        }
    }
}
