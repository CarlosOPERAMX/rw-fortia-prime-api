using Microsoft.AspNetCore.Mvc;
using rw_fortia_prime_api.Dtos;
using rw_fortia_prime_api.Entities;
using rw_fortia_prime_api.Services;

namespace rw_fortia_prime_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly CatalogosService _catalogosService;

        public CatalogosController(CatalogosService catalogosService)
        {
            _catalogosService = catalogosService;
        }

        [HttpGet("puestos")]
        public async Task<ActionResult<IEnumerable<PuestoDto>>> ConsultarPuestos()
        {
            var puestosDto = await _catalogosService.ConsultarPuestos();
            return Ok(puestosDto);
        }

        [HttpGet("trabajadores")] public async Task<ActionResult<IEnumerable<TrabajadorDto>>> ConsultarTrabajadoresActivos()
        {
            var result = await _catalogosService.ConsultarTrabajadoresActivos();
            return Ok(result);
        }
    }
}
