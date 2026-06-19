using AutoMapper;
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
        private readonly IMapper _mapeador;

        public CatalogosController(CatalogosService catalogosService, IMapper mapeador)
        {
            _catalogosService = catalogosService;
            _mapeador = mapeador;
        }

        [HttpGet("puestos")]
        public async Task<ActionResult<IEnumerable<PuestoDto>>> ConsultarPuestos()
        {
            var result = await _catalogosService.ConsultarPuestos();
            var puestosDto = _mapeador.Map<IEnumerable<PuestoDto>>(result);
            return Ok(puestosDto);
        }
    }
}
