using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<RhPuesto>>> ConsultarPuestos()
        {
            var result = await _catalogosService.ConsultarPuestos();
            return Ok(result);
        }
    }
}
