using Microsoft.AspNetCore.Mvc;
using School.Application.DTOs;
using School.Application.Services;

namespace VIARO.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnoController : ControllerBase
    {
        private readonly AlumnoService _alumnoService;

        public AlumnoController(AlumnoService alumnoService)
        {
            _alumnoService = alumnoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            return Ok(await _alumnoService.GetAllAsync(cancellationToken));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            return Ok(await _alumnoService.GetByIdAsync(id, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Add(AlumnoDto dto, CancellationToken cancellationToken)
        { 
            return Ok(await _alumnoService.AddAsync(dto, cancellationToken));
        }

        [HttpPut]
        public async Task<IActionResult> Update(AlumnoDto dto, CancellationToken cancellationToken)
        {
            await _alumnoService.UpdateAsync(dto, cancellationToken);
            
            return Ok(true);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _alumnoService.DeleteAsync(id, cancellationToken);
            return Ok(true);
        }
    }
}
