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

        public async Task<List<object>> ConsultarPuestos()
        {
            var data = await _context.RhPuestos
                .Select(p => new
                {
                    id = p.ClaPuesto,
                    nombre = p.NomPuesto
                })
                .ToListAsync();

            return data.Cast<object>().ToList();
        }

    }
}
