using Microsoft.AspNetCore.Mvc;
using School.Application.DTOs;
using School.Application.Services;

namespace VIARO.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnoGradoController : ControllerBase
    {
        private readonly AlumnoGradoService _alumnoGradoService;

        public AlumnoGradoController(AlumnoGradoService alumnoGradoService)
        {
            _alumnoGradoService = alumnoGradoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            return Ok(await _alumnoGradoService.GetAllAsync(cancellationToken));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            return Ok(await _alumnoGradoService.GetByIdAsync(id, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Add(AlumnoGradoDto dto, CancellationToken cancellationToken)
        {
            return Ok(await _alumnoGradoService.AddAsync(dto, cancellationToken));
        }

        [HttpPut]
        public async Task<IActionResult> Update(AlumnoGradoDto dto, CancellationToken cancellationToken)
        {
            await _alumnoGradoService.UpdateAsync(dto, cancellationToken);
            return Ok(true);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _alumnoGradoService.DeleteAsync(id, cancellationToken);
            return Ok(true);
        }
    }
}
