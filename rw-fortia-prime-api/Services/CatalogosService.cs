using AutoMapper;
using Microsoft.EntityFrameworkCore;
using rw_fortia_prime_api.Dtos;
using rw_fortia_prime_api.Entities;

namespace rw_fortia_prime_api.Services
{
    public class CatalogosService
    {
        private readonly FortiaDbContext _context;
        private readonly IMapper _mapper;

        public CatalogosService(FortiaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PuestoDto>> ConsultarPuestos()
        {
            var data = await _context.RhPuestos
                .ToListAsync();

            var mapped = _mapper.Map<List<PuestoDto>>(data);
            return mapped;
        }

        public async Task<List<TrabajadorDto>> ConsultarTrabajadoresActivos()
        {
            var data = await (
                from trab in _context.RhTrabs
                join puesto in _context.RhPuestos
                    on trab.ClaPuesto equals puesto.ClaPuesto
                    into puestos
                from puesto in puestos.DefaultIfEmpty()
                where trab.StatusTrab == 'A'
                select new TrabajadorDto
                {
                    ClaTrab = trab.ClaTrab,
                    NomTrab = trab.NomTrab.Trim(),
                    ApPaterno = trab.ApPaterno.Trim(),
                    ApMaterno = trab.ApMaterno.Trim(),
                    NomPuesto = puesto != null ? puesto.NomPuesto.Trim() : null,
                    ClaPuesto = trab.ClaPuesto
                }
            ).ToListAsync();

            return data;
        }
    }
}
